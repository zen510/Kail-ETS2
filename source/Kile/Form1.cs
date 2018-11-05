using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Kile
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //ウインドウ関連の処理
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.MouseDown += new MouseEventHandler(Form1_MouseDown);
            panel1.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        private void powerbutton_Click(object sender, EventArgs e)
        {
            /*System.IO.Stream strm = Properties.Resources._60;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(strm);
            player.PlaySync();
            player.Dispose();*/
            panel1.Visible = !panel1.Visible;
            settingDisplay.Visible = false;
            updatetimer.Enabled = !updatetimer.Enabled;
            indicator.BackColor = Color.FromArgb(33, 33, 32);
        }

        bool flag = false;
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = flag;
            settingDisplay.Visible = !flag;
            flag = !flag;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private Point mousePoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button ) == MouseButtons.Left) mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button ) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        int Speed;
        int CruiseSpeed;
        int SpeedLimit;
        int Fuel;
        int Distance;
        int Gear;
        string City;
        string Company;
        bool AirPressureWarning;
        bool ParkBrake;
        bool HighBeam;
        bool LowBeam;
        bool RightBlinker;
        bool LeftBlinker;
        string CargoName;
        int Mass;
        DateTime TimeNow;
        DateTime NextRestTime;
        DateTime DeadLineTime;
        DateTime RemainingTime;
        DateTime EstimatedTime;

        private void updatetimer_Tick(object sender, EventArgs e)
        {
            string IP = "localhost";
            string URL = "http://"+IP+":25555/api/ets2/telemetry";
            string json = null;
            WebClient client = new WebClient();
            try
            {
                client.Encoding = System.Text.Encoding.UTF8;
              json = client.DownloadString(URL);
            }
            catch (System.Net.WebException)
            {
                updatetimer.Enabled = false;
                indicator.BackColor = Color.Crimson;
                var result = MessageBox.Show("サーバに接続できません。", " Kile ALPHA1.0", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                panel1.Visible = false;
                indicator.BackColor = Color.FromArgb(33, 33, 32);
                if (result == DialogResult.Retry) powerbutton.PerformClick();
                return;
            }

            //byte[] bytesUTF8 = System.Text.Encoding.Default.GetBytes(json);
            //json = System.Text.Encoding.UTF8.GetString(bytesUTF8);
            Telemetry telemetry = JsonConvert.DeserializeObject<Telemetry>(json);
            Speed = (int)telemetry.truck.speed;
            CruiseSpeed = (int)telemetry.truck.cruiseControlSpeed;
            SpeedLimit = (int)telemetry.navigation.speedLimit;
            Fuel = (int)telemetry.truck.fuel;
            Distance = telemetry.navigation.estimatedDistance;
            Gear = telemetry.truck.displayedGear;
            City = telemetry.job.destinationCity;
            Company = telemetry.job.destinationCompany;
            AirPressureWarning = telemetry.truck.airPressureWarningOn;
            ParkBrake = telemetry.truck.parkBrakeOn;
            HighBeam = telemetry.truck.lightsBeamHighOn;
            LowBeam = telemetry.truck.lightsBeamLowOn;
            RightBlinker = telemetry.truck.blinkerRightOn;
            LeftBlinker = telemetry.truck.blinkerLeftOn;
            CargoName = telemetry.trailer.name;
            CargoName = telemetry.trailer.name;
            Mass = (int)telemetry.trailer.mass;
            TimeNow = telemetry.game.time;
            NextRestTime = telemetry.game.nextRestStopTime;
            DeadLineTime = telemetry.job.deadlineTime;
            RemainingTime = telemetry.job.remainingTime;
            EstimatedTime = telemetry.navigation.estimatedTime;
            UpdateInfoDisplay();
            indicator.BackColor = Color.Lime;
        }

        void UpdateInfoDisplay()//画面の更新
        {
            truckspeed.Text = Speed.ToString();
            cruisecontrolspeed.Text = CruiseSpeed.ToString();
            if  (SpeedLimit != 0) { speedlimit.Visible = true; speedlimit.Text = SpeedLimit.ToString(); }
            else speedlimit.Visible = false;
            fuel.Text = Fuel.ToString() + "L";
            distance.Text = (Distance / 1000).ToString() + "km";
            if      (Gear ==0) gear.Text = " N ";
            else if (Gear > 0) gear.Text = "D" + Gear.ToString();
            else if (Gear < 0) gear.Text = "R" + (Gear * -1).ToString();
            city.Text = City;
            company.Text = Company;
            airpressure.Visible = AirPressureWarning;
            parkbrake.Visible = ParkBrake;
            hazard.Visible = LeftBlinker & RightBlinker;
            if (HighBeam == true) { light.Visible = true; light.Image = Kile.Properties.Resources.highbeam; }
            else if (LowBeam == true) { light.Visible = true; light.Image = Kile.Properties.Resources.lowbeam; }
            else light.Visible = false;
            if (Mass == 0) cargo.Visible = false;
            else cargo.Visible = true;
            cargo.Text = CargoName +"("+ (Mass / 1000).ToString()+"t)";
            day.Text = TimeNow.ToString("ddd");
            time.Text = TimeNow.ToString("HH:mm");
            remainingTime.Text = DeadLineTime.ToString("H時間m分");
            if (remainingTime.Text == "0時間0分") remainingTime.Visible = false;
            else remainingTime.Visible = true;
            nextreststoptime.Text = NextRestTime.ToString("H時間m分");
            eta.Text = EstimatedTime.ToString("H時間m分");
            TimeSpan Arrives = EstimatedTime.TimeOfDay;
            arrives.Text = (TimeNow.Add(Arrives)).ToString("tthh:mm");
            if (eta.Text == "0時間0分") { eta.Visible = false; arrives.Visible = false; }
            else {eta.Visible = true; arrives.Visible = true;}

        }
    }
}





//以下json用クラス
public class Telemetry
{
    public Game game { get; set; }
    public Truck truck { get; set; }
    public Trailer trailer { get; set; }
    public Job job { get; set; }
    public Navigation navigation { get; set; }
}

public class Game
{
    public bool connected { get; set; }
    public bool paused { get; set; }
    public DateTime time { get; set; }
    public float timeScale { get; set; }
    public DateTime nextRestStopTime { get; set; }
    public string version { get; set; }
    public string telemetryPluginVersion { get; set; }
}

public class Truck
{
    public string id { get; set; }
    public string make { get; set; }
    public string model { get; set; }
    public float speed { get; set; }
    public float cruiseControlSpeed { get; set; }
    public bool cruiseControlOn { get; set; }
    public float odometer { get; set; }
    public int gear { get; set; }
    public int displayedGear { get; set; }
    public int forwardGears { get; set; }
    public int reverseGears { get; set; }
    public string shifterType { get; set; }
    public float engineRpm { get; set; }
    public float engineRpmMax { get; set; }
    public float fuel { get; set; }
    public float fuelCapacity { get; set; }
    public float fuelAverageConsumption { get; set; }
    public float fuelWarningFactor { get; set; }
    public bool fuelWarningOn { get; set; }
    public float wearEngine { get; set; }
    public float wearTransmission { get; set; }
    public float wearCabin { get; set; }
    public float wearChassis { get; set; }
    public float wearWheels { get; set; }
    public float userSteer { get; set; }
    public float userThrottle { get; set; }
    public float userBrake { get; set; }
    public float userClutch { get; set; }
    public float gameSteer { get; set; }
    public float gameThrottle { get; set; }
    public float gameBrake { get; set; }
    public float gameClutch { get; set; }
    public int shifterSlot { get; set; }
    public bool engineOn { get; set; }
    public bool electricOn { get; set; }
    public bool wipersOn { get; set; }
    public int retarderBrake { get; set; }
    public int retarderStepCount { get; set; }
    public bool parkBrakeOn { get; set; }
    public bool motorBrakeOn { get; set; }
    public float brakeTemperature { get; set; }
    public float adblue { get; set; }
    public float adblueCapacity { get; set; }
    public float adblueAverageConsumpton { get; set; }
    public bool adblueWarningOn { get; set; }
    public float airPressure { get; set; }
    public bool airPressureWarningOn { get; set; }
    public float airPressureWarningValue { get; set; }
    public bool airPressureEmergencyOn { get; set; }
    public float airPressureEmergencyValue { get; set; }
    public float oilTemperature { get; set; }
    public float oilPressure { get; set; }
    public bool oilPressureWarningOn { get; set; }
    public float oilPressureWarningValue { get; set; }
    public float waterTemperature { get; set; }
    public bool waterTemperatureWarningOn { get; set; }
    public float waterTemperatureWarningValue { get; set; }
    public float batteryVoltage { get; set; }
    public bool batteryVoltageWarningOn { get; set; }
    public float batteryVoltageWarningValue { get; set; }
    public float lightsDashboardValue { get; set; }
    public bool lightsDashboardOn { get; set; }
    public bool blinkerLeftActive { get; set; }
    public bool blinkerRightActive { get; set; }
    public bool blinkerLeftOn { get; set; }
    public bool blinkerRightOn { get; set; }
    public bool lightsParkingOn { get; set; }
    public bool lightsBeamLowOn { get; set; }
    public bool lightsBeamHighOn { get; set; }
    public bool lightsAuxFrontOn { get; set; }
    public bool lightsAuxRoofOn { get; set; }
    public bool lightsBeaconOn { get; set; }
    public bool lightsBrakeOn { get; set; }
    public bool lightsReverseOn { get; set; }
    public Placement placement { get; set; }
    public Acceleration acceleration { get; set; }
    public Head head { get; set; }
    public Cabin cabin { get; set; }
    public Hook hook { get; set; }
}

public class Placement
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
    public float heading { get; set; }
    public float pitch { get; set; }
    public float roll { get; set; }
}

public class Acceleration
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
}

public class Head
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
}

public class Cabin
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
}

public class Hook
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
}

public class Trailer
{
    public bool attached { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public float mass { get; set; }
    public float wear { get; set; }
    public Placement1 placement { get; set; }
}

public class Placement1
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
    public float heading { get; set; }
    public float pitch { get; set; }
    public float roll { get; set; }
}

public class Job
{
    public int income { get; set; }
    public DateTime deadlineTime { get; set; }
    public DateTime remainingTime { get; set; }
    public string sourceCity { get; set; }
    public string sourceCompany { get; set; }
    public string destinationCity { get; set; }
    public string destinationCompany { get; set; }
}

public class Navigation
{
    public DateTime estimatedTime { get; set; }
    public int estimatedDistance { get; set; }
    public int speedLimit { get; set; }
}
