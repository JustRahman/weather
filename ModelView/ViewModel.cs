﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using System.Globalization;
using weather.Model;
using weather.Views;
using DevExpress.Xpo;
using System.Threading;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows;
using weather.Command;

namespace weather.ModelView
{
    class ViewModel:ViewModelBase
    {

        public INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
        public static UnitOfWork uow;

        #region

        private string _current_country;
        public string current_country
        {
            get
            {
                return _current_country;
            }
            set
            {
                SetValue(ref _current_country , value);
            }
        }


        private string _blact_to_white;
        public string blact_to_white
        {
            get
            {
                return _blact_to_white;
            }
            set
            {
                SetValue(ref _blact_to_white, value);
            }
        }

        private string _all_background;
        public string all_background
        {
            get
            {
                return _all_background;
            }
            set
            {
                SetValue(ref _all_background, value);
            }
        }


        private string _btn_change_let;
        public string btn_change_let
        {
            get
            {
                return _btn_change_let;
            }
            set
            {
                SetValue(ref _btn_change_let, value);
            }
        }

        private string _btn_change;
        public string btn_change
        {
            get
            {
                return _btn_change;
            }
            set
            {
                SetValue(ref _btn_change, value);
            }
        }




        private string _real_feel;
        public string real_feel
        {
            get
            {
                return _real_feel;
            }
            set
            {
                SetValue(ref _real_feel, value);
            }
        }

        
        private int _coord_lat;
        public int coord_lat
        {
            get
            {
                return _coord_lat;
            }
            set
            {
                SetValue(ref _coord_lat, value);
            }
        }


        private int _coord_lon;
        public int coord_lon
        {
            get
            {
                return _coord_lon;
            }
            set
            {
                SetValue(ref _coord_lon, value);
            }
        }

        private int _temp_min;
        public int temp_min
        {
            get
            {
                return _temp_min;
            }
            set
            {
                SetValue(ref _temp_min, value);
            }
        }

        private int _temp_max;
        public int  temp_max
        {
            get
            {
                return _temp_max;
            }
            set
            {
                SetValue(ref _temp_max, value);
            }
        }


        private string _pressure;
        public string pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                SetValue(ref _pressure, value);
            }
        }


        private string _temperature;
        public string temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                SetValue(ref _temperature, value);
            }
        }
        

        private string _wind;
        public string wind
        {
            get
            {
                return _wind;
            }
            set
            {
                SetValue(ref _wind, value);
            }
        }

        private string _visibility;
        public string visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
                SetValue(ref _visibility, value);
            }
        }

        private string _weather_main;
        public string weather_main
        {
            get
            {
                return _weather_main;
            }
            set
            {
                SetValue(ref _weather_main , value);
            }
        }

        

        private string _min_temperatur;
        public string min_temperatur
        {
            get
            {
                return _min_temperatur;
            }
            set
            {
                SetValue(ref _min_temperatur, value);
            }
        }

        private string _max_temperatur;
        public string max_temperatur
        {
            get
            {
                return _max_temperatur;
            }
            set
            {
                SetValue(ref _max_temperatur, value);
            }
        }


        private string _clothes_description;
        public string clothes_description
        {
            get
            {
                return _clothes_description;
            }
            set
            {
                SetValue(ref _clothes_description, value);
            }
        }

        private string _woman_clothes;
        public string woman_clothes
        {
            get
            {
                return _woman_clothes;
            }
            set
            {
                SetValue(ref _woman_clothes, value);
            }
        }


        private string _svg_path;
        public string svg_path
        {
            get
            {
                return _svg_path;
            }
            set
            {
                SetValue(ref _svg_path, value);
            }
        }

        private string _humidity;
        public string humidity
        {
            get
            {
                return _humidity;
            }
            set
            {
                SetValue(ref _humidity, value);
            }
        }

        private string _time;
        public string time
        {
            get
            {
                return _time;
            }
            set
            {
                SetValue(ref _time, value);
            }
        }

        private string _general;
        public string general
        {
            get
            {
                return _general;
            }
            set
            {
                SetValue(ref _general , value);
            }

                
        }

        private string _language;
        public string language
        {
            get
            {
                return _language;
            }
            set
            {
                SetValue(ref _language, value);
            }


        }

        private string _current_city;
        public string current_city
        {
            get
            {
                return _current_city;
            }
            set
            {
                SetValue(ref _current_city, value);
            }


        }



        private string _first_extra_clothes;
        public string first_extra_clothes
        {
            get
            {
                return _first_extra_clothes;
            }
            set
            {
                SetValue(ref _first_extra_clothes, value);
            }


        }

        private string _third_extra_clothes;
        public string third_extra_clothes
        {
            get
            {
                return _third_extra_clothes;
            }
            set
            {
                SetValue(ref _third_extra_clothes, value);
            }


        }

        private string _btn_text;
        public string btn_text
        {
            get
            {
                return _btn_text;
            }
            set
            {
                SetValue(ref _btn_text, value);
            }


        }

        private string _second_extra_clothes;
        public string second_extra_clothes
        {
            get
            {
                return _second_extra_clothes;
            }
            set
            {
                SetValue(ref _second_extra_clothes, value);
            }


        }

        private string _color;
        public string color
        {
            get
            {
                return _color;
            }
            set
            {
                SetValue(ref _color , value);
            }
        }

        private string _go_back_btn;
        public string go_back_btn
        {
            get
            {
                return _go_back_btn;
            }
            set
            {
                SetValue(ref _go_back_btn, value);
            }
        }



        private string _current_main;
        public string current_main
        {
            get
            {
                return _current_main;
            }
            set
            {
                SetValue(ref _current_main, value);
            }
        }



        private string _man_clothes;
        public string man_clothes
        {
            get
            {
                return _man_clothes;
            }
            set
            {
                SetValue(ref _man_clothes , value);
            }
        }

        private string _item_sel;
        public string item_sel
        {
            get
            {
                return _item_sel;
            }
            set
            {
                SetValue(ref _item_sel, value);
            }

        }

        private string _current_weather_lan;
        public string current_weather_lan
        {
            get
            {
                return _current_weather_lan;
            }
            set
            {
                SetValue(ref _current_weather_lan, value);
            }

        }


        private string _pressure_lan;
        public string pressure_lan
        {
            get
            {
                return _pressure_lan;
            }
            set
            {
                SetValue(ref _pressure_lan, value);
            }

        }

        private string _refresh_lan;
        public string refresh_lan
        {
            get
            {
                return _refresh_lan;
            }
            set
            {
                SetValue(ref _refresh_lan, value);
            }

        }

        private string _details_lan;
        public string details_lan
        {
            get
            {
                return _details_lan;
            }
            set
            {
                SetValue(ref _details_lan, value);
            }

        }

        private string _search_city;
        public string search_city
        {
            get
            {
                return _search_city;
            }
            set
            {
                SetValue(ref _search_city, value);
            }

        }

        private string _direction;
        public string direction
        {
            get
            {
                return _direction;
            }
            set
            {
                SetValue(ref _direction, value);
            }

        }

        private string _latitude_lan;
        public string latitude_lan
        {
            get
            {
                return _latitude_lan;
            }
            set
            {
                SetValue(ref _latitude_lan, value);
            }

        }
        private string _longtitude_lan;
        public string longtitude_lan
        {
            get
            {
                return _longtitude_lan;
            }
            set
            {
                SetValue(ref _longtitude_lan, value);
            }

        }

        private string _sunrise;
        public string sunrise
        {
            get
            {
                return _sunrise;
            }
            set
            {
                SetValue(ref _sunrise, value);
            }

        }

        private string _shortime;
        public string shortime
        {
            get
            {
                return _shortime;
            }
            set
            {
                SetValue(ref _shortime, value);
            }

        }

        private string _min_temperature_lan;
        public string min_temperature_lan
        {
            get
            {
                return _min_temperature_lan;
            }
            set
            {
                SetValue(ref _min_temperature_lan, value);
            }

        }
        private string _max_temperature_lan;
        public string max_temperature_lan
        {
            get
            {
                return _max_temperature_lan;
            }
            set
            {
                SetValue(ref _max_temperature_lan, value);
            }

        }

        private double _hell;
        public double hell
        {
            get
            {
                return _hell;
            }
            set
            {
                SetValue(ref _hell, value);
            }

        }

        private double _feel_hell;
        public double feel_hell
        {
            get
            {
                return _feel_hell;
            }
            set
            {
                SetValue(ref _feel_hell, value);
            }

        }

        private double _max_hell;
        public double max_hell
        {
            get
            {
                return _max_hell;
            }
            set
            {
                SetValue(ref _max_hell, value);
            }

        }

        private double _min_hell;
        public double min_hell
        {
            get
            {
                return _min_hell;
            }
            set
            {
                SetValue(ref _min_hell, value);
            }

        }


        private string _wind_lan;
        public string wind_lan
        {
            get
            {
                return _wind_lan;
            }
            set
            {
                SetValue(ref _wind_lan, value);
            }

        }
        private string _humidity_lan;
        public string humidity_lan
        {
            get
            {
                return _humidity_lan;
            }
            set
            {
                SetValue(ref _humidity_lan, value);
            }

        }
        private string _visibility_lan;
        public string visibility_lan
        {
            get
            {
                return _visibility_lan;
            }
            set
            {
                SetValue(ref _visibility_lan, value);
            }

        }

        private string _highlights;
        public string highlights
        {
            get
            {
                return _highlights;
            }
            set
            {
                SetValue(ref _highlights, value);
            }

        }

        private string _language_api;
        public string language_api
        {
            get
            {
                return _language_api;
            }
            set
            {
                SetValue(ref _language_api, value);
            }

        }

        private string _lan_lon;
        public string lan_lon
        {
            get
            {
                return _lan_lon;
            }
            set
            {
                SetValue(ref _lan_lon, value);
            }

        }

        private string _quality;
        public string quality
        {
            get
            {
                return _quality;
            }
            set
            {
                SetValue(ref _quality, value);
            }

        }

        private string _icon_hum;
        public string icon_hum
        {
            get
            {
                return _icon_hum;
            }
            set
            {
                SetValue(ref _icon_hum, value);
            }

        }

        private string _mar_btn;
        public string mar_btn
        {
            get
            {
                return _mar_btn;
            }
            set
            {
                SetValue(ref _mar_btn, value);
            }

        }

        private bool _isenabled;
        public bool isenabled
        {
            get
            {
                return _isenabled;
            }
            set
            {
                SetValue(ref _isenabled , value);
            }
        }

        private string _back_color;
        public string back_color
        {
            get
            {
                return _back_color;
            }
            set
            {
                SetValue(ref _back_color, value);
            }

        }

        private string _svg_path_weather;
        public string svg_path_weather
        {
            get
            {
                return _svg_path_weather;
            }
            set
            {
                SetValue(ref _svg_path_weather, value);
            }

        }

        private string _startdatetime;
        public string startdatetime
        {
            get
            {
                return _startdatetime;
            }
            set
            {
                SetValue(ref _startdatetime, value);
            }

        }

        private string _btn_bck;
        public string btn_bck
        {
            get
            {
                return _btn_bck;
            }
            set
            {
                SetValue(ref _btn_bck, value);
            }

        }

        private string _btn_frg;
        public string btn_frg
        {
            get
            {
                return _btn_frg;
            }
            set
            {
                SetValue(ref _btn_frg, value);
            }

        }

        private string _max_min;
        public string max_min
        {
            get
            {
                return _max_min;
            }
            set
            {
                SetValue(ref _max_min, value);
            }

        }

        private string _finishdatetime;
        public string finishdatetime
        {
            get
            {
                return _finishdatetime;
            }
            set
            {
                SetValue(ref _finishdatetime, value);
            }

        }

        private string _btn_cel_frg;
        public string btn_cel_frg
        {
            get
            {
                return _btn_cel_frg;
            }
            set
            {
                SetValue(ref _btn_cel_frg, value);
            }

        }

        private string _btn_cel_bck;
        public string btn_cel_bck
        {
            get
            {
                return _btn_cel_bck;
            }
            set
            {
                SetValue(ref _btn_cel_bck, value);
            }

        }




        private readonly ISplashScreenService _waitIndicatorService;
        private bool _IsBusy;
        public bool IsBusy
        {
            get
            {
                return _IsBusy;
            }
            set
            {
                if (value && _waitIndicatorService != null)
                {
                    _waitIndicatorService.ShowSplashScreen();
                }
                else if (!value && _waitIndicatorService != null)
                    _waitIndicatorService.HideSplashScreen();
                SetValue(ref _IsBusy, value);


            }
        }
        #endregion

        string man_wear ;

        

        string path2 = System.AppDomain.CurrentDomain.BaseDirectory;
        string path3;
        string path4;

        static HttpClient httpClient;

        DateTime current_time;

        List<string> all_paths;

        List<png_weather> png_weathers_collector;

        bool isexit = false;

        int k = 0;
        int counter;
        int counterr;
        bool turkmen;
        string language_direction;
        bool approximatly_main;

        Random rd = new Random();
        Random rdr = new Random();
        string real_feeling;
        bool stupid;

        XPCollection<png_icon> pin_path_collector;


        public DelegateCommand details { get; set; }
        public DelegateCommand refresh { get; set; }
        public DelegateCommand OnViewLoadedCommand { get; set; } 
        public DelegateCommand go_back { get;set; }
        public DelegateCommand btn_color { get; set; }
        public DelegateCommand Selection_changed_cmd { get; set; }
        public DelegateCommand open_combo_cmd { get; set; }
        public DelegateCommand btn_cel { get; set; }
        public DelegateCommand btn_far { get; set; }

        public DelegateCommand btn_change_com { get; set; }

        public ObservableCollection<string> items_xpo { get; set; }


        public MyDelegateCommand cmdLogin { get; set; }
        public MyDelegateCommand close_application { get; set; }
        private System.Windows.Forms.NotifyIcon m_notifyIcon;
        Window wnd;

        public ViewModel()
        {
            all_background = "White";
            btn_change = "Black";
            btn_change_let = "White";

            png_weathers_collector = new List<png_weather>();

            mar_btn = "20 0 0 0";

            btn_cel_bck = "Black";
            btn_cel_frg = "White";

            btn_frg = "Black";
            btn_bck = "White";
            m_notifyIcon = new System.Windows.Forms.NotifyIcon();

            cmdLogin = new MyDelegateCommand(rahman => LoginCommand(rahman));
            m_notifyIcon.Icon = new System.Drawing.Icon(@"C:\Data\source\WPF\weather\bin\Debug\TheAppIcon.ico");
            close_application = new MyDelegateCommand(pep => close_application_cmd(pep));

            stupid = false;

            uow = new UnitOfWork();

            color = "LightBlue";
            isenabled = false;
            back_color = "White";
            btn_text = " ";
            turkmen = false;
            approximatly_main = false;

            items_xpo = new ObservableCollection<string>();


            pin_path_collector = new XPCollection<png_icon>(uow);

            blact_to_white = "Black";

            int num2 = 0;
            TimerCallback callback = new TimerCallback(Count);
            Timer timer = new Timer(callback, num2, 0, 100000);

            current_time = DateTime.Now;
            all_paths = new List<string>();

            items_xpo.Add("Russian");
            items_xpo.Add("English");
            items_xpo.Add("Turkmen");
             
            details = new DelegateCommand(()=> details_cmd());
            refresh = new DelegateCommand(()=> refresh_cmd());
            OnViewLoadedCommand = new DelegateCommand(()=> OnViewLoadedCommand_cmd());
            go_back = new DelegateCommand(() => go_back_cmd());
            btn_color = new DelegateCommand(()=> btn_color_cmd());
            open_combo_cmd = new DelegateCommand(()=> open_combo());
            btn_cel = new DelegateCommand(()=> btn_cel_cmd());
            btn_far = new DelegateCommand(()=> btn_far_cmd());
            btn_change_com = new DelegateCommand(() => btn_change_com_cmd());


            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.openweathermap.org/");

           

            time = Convert.ToString(current_time);


            _waitIndicatorService = DevExpress.Mvvm.ServiceContainer.Default.GetService<ISplashScreenService>("WaitingService");


            try
            {
                if (LogginParametrs.language == "Russian")
                {
                    current_weather_lan = "ПОГОДА СЕЙЧАС";
                    pressure_lan = "ДАВЛЕНИЕ";
                    wind_lan = "ВЕТЕР";
                    humidity_lan = "ВЛАЖНОСТЬ";
                    visibility_lan = "ВИДИМОСТЬ";
                    language_api = "ru";
                    real_feeling = "Ощущ";
                    max_temperature_lan = "Мах Температура";
                    min_temperature_lan = "Мшт Температура";
                    longtitude_lan = "Долгота";
                    latitude_lan = "Ширина";
                    language_direction = "Russian";
                    sunrise = "Восход Заход";
                    refresh_lan = "Обновить";
                    details_lan = "Больше→";
                    highlights = "Основные моменты";
                    go_back_btn = "Обратно";
                    max_min = "Температура";
                    lan_lon = "Высота над морем";
                    func();
                }
                else if (LogginParametrs.language == "English")
                {
                    current_weather_lan = "CURRENT WEATHER";
                    pressure_lan = "PRESSURE";
                    wind_lan = "WIND";
                    humidity_lan = "HUMIDITY";
                    visibility_lan = "VISIBILITY";
                    language_api = "en";
                    real_feeling = "RealFeel";
                    max_temperature_lan = "Max temperature";
                    min_temperature_lan = "Min temperature";
                    longtitude_lan = "longtitude";
                    latitude_lan = "latitude";
                    language_direction = "British";
                    sunrise = "Sunrise SunSet";
                    refresh_lan = "Refresh";
                    details_lan = "More→";
                    highlights = "Today's highlights";
                    go_back_btn = "Go back";
                    max_min = "Temperatur";
                    lan_lon = "Atitude";
                    func();
                }
                else if (LogginParametrs.language == "Turkmen")
                {
                    current_weather_lan = "SU WAGTAKY HOWA";
                    pressure_lan = "DAWLEENIYE";
                    wind_lan = "SEMAL";
                    humidity_lan = "ÇIGLYK";
                    visibility_lan = "ARRASAÇYLYK";
                    language_api = "tr";
                    real_feeling = "Duymak";
                    max_temperature_lan = "Max temperature";
                    min_temperature_lan = "Min temperature";
                    longtitude_lan = "Uzynlyk";
                    latitude_lan = "Giňişlik";
                    sunrise = "GunBatar GunDogan";
                    turkmen = true;
                    language_direction = "Turkmen";
                    refresh_lan = "Tazelemek";
                    details_lan = "Koprak→";
                    highlights = "Su gundaki pursatlar";
                    go_back_btn = "Iza";
                    max_min = "Temperatur";
                    lan_lon = "Uzynlyk";
                    func();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something in combobox");
            }

        }

      

        private void btn_change_com_cmd()
        {
            all_background = "Black";
            btn_change_let = "Black";
            btn_change = "White";
            blact_to_white = "White";
        }

        private void btn_far_cmd()
        {
            if (stupid == true)
            {
                MessageBox.Show("You have already chosed");
            }
            else if (stupid == false)
            {
                btn_bck = "Black";
                btn_frg = "White";
                btn_cel_bck = "White";
                btn_cel_frg = "Black";
                mar_btn = "0 0 0 0";
                temperature = Convert.ToString(Convert.ToInt32(hell + 273.15)) + "°";
                real_feel = $"{real_feeling}" + "®" + Convert.ToString(Convert.ToInt32(feel_hell + 272.15)) + "°";
                max_temperatur = Convert.ToString(Convert.ToInt32(max_hell + 272.15)) + "°";
                min_temperatur = Convert.ToString(Convert.ToInt32(min_hell + 272.15)) + "°";

                stupid = true;
            }
        }

        private void btn_cel_cmd()
        {
           if (stupid == false)
           {
                MessageBox.Show("You have already chosed");
           }
           else if (stupid == true)
           {
                btn_cel_bck = "Black";
                btn_cel_frg = "White";
                btn_bck = "White";
                btn_frg = "Black";
                mar_btn = "20 0 0 0";
                temperature = Convert.ToString(Convert.ToInt32(hell)) + "°";
                real_feel = $"{real_feeling}" + "®" + Convert.ToString(Convert.ToInt32(feel_hell)) + "°";
                max_temperatur = Convert.ToString(Convert.ToInt32(max_hell )) + "°";
                min_temperatur = Convert.ToString(Convert.ToInt32(min_hell )) + "°";
                stupid = false;
           }

        }

        private void LoginCommand(object o)
        {
            object[] objs = o as object[];
            wnd = (Window)objs[0];
            wnd.StateChanged += new EventHandler(OnStateChanged);
            m_notifyIcon.Click += new EventHandler(m_notifyIcon_Click);
            wnd.IsVisibleChanged += Wnd_IsVisibleChanged;
            wnd.WindowState = WindowState.Minimized;
        }

        private void Wnd_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            CheckTrayIcon();
        }

        private WindowState m_storedWindowState = WindowState.Normal;

        private void CheckTrayIcon()
        {
            ShowTrayIcon(!wnd.IsVisible);
        }

        private void ShowTrayIcon(bool show)
        {
            if (m_notifyIcon != null)
                m_notifyIcon.Visible = show;
        }

        private void m_notifyIcon_Click(object sender, EventArgs e)
        {
            wnd.Show();
            wnd.WindowState = WindowState.Normal;
        }

        private void OnStateChanged(object sender, EventArgs e)
        {
            if (wnd.WindowState == WindowState.Minimized)
            {
                wnd.Hide();
            }
        }

        private void close_application_cmd(object pep)
        {
            object[] objs = pep as object[];
            wnd = (Window)objs[0];
            wnd.Close();
        }

        private void open_combo()
        {
            if (current_city == null)
            {
                MessageBox.Show("Fill your textbox");
            }
            else
            {
                isenabled = true;
                back_color = "LightGreen";
                btn_text = "✓";
            }
        }

        

        private void btn_color_cmd()
        {
            

            color = "LightGreen";

            
        }

        private void Count(object state)
        {
            //current_time = DateTime.Now;
            //time = Convert.ToString(current_time);
        }

        private void go_back_cmd()
        {

            try
            { 
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        public  async void func()
        {        
         
            IsBusy = true;

            if (File.Exists(@"C:\Data\source\WPF\weather\bin\Debug\test_png.json"))
            {
                String JSONtxt = File.ReadAllText(@"C:\Data\source\WPF\weather\bin\Debug\test_png.json");
                var accounts = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<png_weather>>(JSONtxt);
                png_weathers_collector = accounts.ToList();
            }

            string appid = "1de7c89b398a688cd2e5f45782df243f";
            string city = $"{LogginParametrs.cityName}";
            try
            {




                HttpResponseMessage response = await httpClient.GetAsync($@"data/2.5/weather?q={city}&lang={language_api}&appid={appid}");
                string str = response.Content.ReadAsStringAsync().Result;
                RootObject model1 = JsonConvert.DeserializeObject<RootObject>(str);

                current_country = model1.Sys.Country;
                temperature = Convert.ToString(Convert.ToInt32(model1.Main.Temp - 273.15)) + "°";
                hell = model1.Main.Temp - 273.15;
                min_temperatur = Convert.ToString(Convert.ToInt32(model1.Main.TempMin - 273.15)) + "°";
                max_temperatur = Convert.ToString(Convert.ToInt32(model1.Main.TempMax - 273.15)) + "°";

                min_hell = Convert.ToInt32(model1.Main.TempMin - 273.15);
                max_hell = Convert.ToInt32(model1.Main.TempMax - 273.15);

                real_feel = $"{real_feeling}" + "®" + ((Convert.ToInt32(model1.Main.FeelsLike - 273.15)).ToString()) + "°";
                feel_hell = model1.Main.FeelsLike - 273.15;
                pressure = (model1.Main.Pressure).ToString() + "kPa";
                visibility = (model1.Visibility/1000).ToString() + "km"; 
                wind = (model1.Wind.Speed).ToString() + "m/s";
                humidity = (model1.Main.Humidity).ToString() + "%";
                temp_max = Convert.ToInt32(model1.Main.TempMax - 273.15);
                temp_min = Convert.ToInt32(model1.Main.TempMin - 273.15);
                coord_lon = Convert.ToInt32(model1.Coord.Lon);
                coord_lat = Convert.ToInt32(model1.Coord.Lat);
                general = time + " " + current_country;
                

                double ticks = double.Parse(Convert.ToString(model1.Sys.Sunrise));
                TimeSpan times = TimeSpan.FromMilliseconds(ticks);
                DateTime startdate = new DateTime(1970, 1, 1) + times;           
                string[] risetime = Convert.ToString(startdate).Split(' ');
                startdatetime = risetime[1];


                double ticks2 = double.Parse(Convert.ToString(model1.Sys.Sunset));
                TimeSpan times2 = TimeSpan.FromMilliseconds(ticks2);
                DateTime startdate2 = new DateTime(1970, 1, 1) + times2;
                string[] setime = Convert.ToString(startdate2).Split(' ');
                finishdatetime = setime[1];



                #region SNWE changed
                if (LogginParametrs.language == "English")
                {
                    if (model1.Wind.Deg == 0)
                    {
                        direction = "S";
                    }
                    else if (model1.Wind.Deg == 90)
                    {
                        direction = "E";
                    }
                    else if (model1.Wind.Deg == 180)
                    {
                        direction = "N";
                    }
                    else if (model1.Wind.Deg == 270)
                    {
                        direction = "W";
                    }
                    else if (model1.Wind.Deg > 0 && model1.Wind.Deg < 90)
                    {
                        direction = "SE";
                    }
                    else if (model1.Wind.Deg > 90 && model1.Wind.Deg < 180)
                    {
                        direction = "NE";
                    }
                    else if (model1.Wind.Deg > 180 && model1.Wind.Deg < 270)
                    {
                        direction = "NW";
                    }
                    else if (model1.Wind.Deg > 270 && model1.Wind.Deg < 360)
                    {
                        direction = "SW";
                    }
                }
                else if (LogginParametrs.language == "Russian")
                {
                    if (model1.Wind.Deg == 0)
                    {
                        direction = "С";
                    }
                    else if (model1.Wind.Deg == 90)
                    {
                        direction = "В";
                    }
                    else if (model1.Wind.Deg == 180)
                    {
                        direction = "Ю";
                    }
                    else if (model1.Wind.Deg == 270)
                    {
                        direction = "З";
                    }
                    else if (model1.Wind.Deg > 0 && model1.Wind.Deg < 90)
                    {
                        direction = "СВ";
                    }
                    else if (model1.Wind.Deg > 90 && model1.Wind.Deg < 180)
                    {
                        direction = "ЮВ";
                    }
                    else if (model1.Wind.Deg > 180 && model1.Wind.Deg < 360)
                    {
                        direction = "ЮЗ";
                    }
                    else if (model1.Wind.Deg > 270 && model1.Wind.Deg < 360)
                    {
                        direction = "СЗ";
                    }
                }
                else if (LogginParametrs.language == "Turkmen")
                {
                    if (model1.Wind.Deg == 0)
                    {
                        direction = "D";
                    }
                    else if (model1.Wind.Deg == 90)
                    {
                        direction = "GD";
                    }
                    else if (model1.Wind.Deg == 180)
                    {
                        direction = "GO";
                    }
                    else if (model1.Wind.Deg == 270)
                    {
                        direction = "GB";
                    }
                    else if (model1.Wind.Deg > 0 && model1.Wind.Deg < 90)
                    {
                        direction = "DGD";
                    }
                    else if (model1.Wind.Deg > 90 && model1.Wind.Deg < 180)
                    {
                        direction = "GOGD";
                    }
                    else if (model1.Wind.Deg > 180 && model1.Wind.Deg < 360)
                    {
                        direction = "GOGB";
                    }
                    else if (model1.Wind.Deg > 270 && model1.Wind.Deg < 360)
                    {
                        direction = "DGB";
                    }
                }
                #endregion

                #region smiles

                if (LogginParametrs.language == "English")
                {
                    if (model1.Main.Humidity == 0)
                    {
                        quality = "Virtually impossibled";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\blue.jpg";
                    }
                    else if (model1.Main.Humidity > 0 && model1.Main.Humidity < 20)
                    {
                        quality = "bad";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\red.jpg";
                    }
                    else if (model1.Main.Humidity > 20 && model1.Main.Humidity < 40)
                    {
                        quality = "Not good";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\yellow.jpg";
                    }
                    else if (model1.Main.Humidity > 40 && model1.Main.Humidity < 60)
                    {
                        quality = "Normal";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\green.jpg";
                    }
                    else if (model1.Main.Humidity > 60 && model1.Main.Humidity < 80)
                    {
                        quality = "Not good";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\yellow.jpg";
                    }
                    else if (model1.Main.Humidity > 80 && model1.Main.Humidity < 100)
                    {
                        quality = "Bad";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\red.jpg";
                    }
                    else
                    {
                        quality = "Imposible";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\blue.jpg";
                    }

                }
                else if (LogginParametrs.language == "Russian")
                {
                    if (model1.Main.Humidity == 0)
                    {
                        quality = "Практически невозможно";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\blue.jpg";
                    }
                    else if (model1.Main.Humidity > 0 && model1.Main.Humidity < 20)
                    {
                        quality = "Плохо";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\red.jpg";
                    }
                    else if (model1.Main.Humidity > 20 && model1.Main.Humidity < 40)
                    {
                        quality = "Неплохо";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\yellow.jpg";
                    }
                    else if (model1.Main.Humidity > 40 && model1.Main.Humidity < 60)
                    {
                        quality = "Нормально";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\green.jpg";
                    }
                    else if (model1.Main.Humidity > 60 && model1.Main.Humidity < 80)
                    {
                        quality = "Неплохо";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\yellow.jpg";
                    }
                    else if (model1.Main.Humidity > 80 && model1.Main.Humidity < 100)
                    {
                        quality = "Плохо";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\red.jpg";
                    }
                    else
                    {
                        quality = "Невозможно";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\blue.jpg";
                    }
                }
                else if (LogginParametrs.language == "Turkmen")
                {
                    if (model1.Main.Humidity == 0)
                    {
                        quality = "Mumkin Dal";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\blue.jpg";
                    }
                    else if (model1.Main.Humidity > 0 && model1.Main.Humidity < 20)
                    {
                        quality = "Erbet";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\red.jpg";
                    }
                    else if (model1.Main.Humidity > 20 && model1.Main.Humidity < 40)
                    {
                        quality = "ErbetDal";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\yellow.jpg";
                    }
                    else if (model1.Main.Humidity > 40 && model1.Main.Humidity < 60)
                    {
                        quality = "Gowy";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\green.jpg";
                    }
                    else if (model1.Main.Humidity > 60 && model1.Main.Humidity < 80)
                    {
                        quality = "ErbetDal";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\yellow.jpg";
                    }
                    else if (model1.Main.Humidity > 80 && model1.Main.Humidity < 100)
                    {
                        quality = "Erbet";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\red.jpg";
                    }
                    else
                    {
                        quality = "Mumkin Dal";
                        icon_hum = @"C:\Data\source\WPF\weather\bin\Debug\clothes\blue.jpg";
                    }
                }

                #endregion




                int counterOfSplit = 0;
                turkmen = false;
                

                //for (int k = 0; k < pin_path_collector.Count - 1; k++)
                //{
                //    if (model1.Weather[0].Description.Contains(" ") && turkmen == false)
                //    {
                //        if (model1.Weather[0].Id == pin_path_collector[k].png_id_weather)
                //        {
                //            
                                
                                
                //            }
                //        }
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}


                current_main = $"{current_weather_lan}" + weather_main;

                svg_path_weather = $@"https://openweathermap.org/img/wn/{model1.Weather[0].Icon}@2x.png";


                //for (int i = 0; i < pin_path_collector.Count; i++)
                //{
                //    if (model1.Weather[0].Id ==  && turkmen == true)
                //    {

                //    }
                //}




                if (model1.Weather[0].Description.Contains(" "))
                {
                    string[] spliter = model1.Weather[0].Description.Split(' ');
                    foreach (string item in spliter)
                    {

                        if (counterOfSplit == 0)
                        {
                            weather_main = weather_main + " " + item[0].ToString().ToUpper() + item.Substring(1);
                            counterOfSplit = 1;
                        }
                        else
                        {
                            weather_main = weather_main + " " + item;
                        }
                    }
                }


                if (turkmen == true)
                {
                    for (int i = 0; i < png_weathers_collector.Count - 1; i++)
                    {
                        if (model1.Weather[0].Id == png_weathers_collector[i].png_id)
                        {
                            string[] spliter = png_weathers_collector[0].png_description.Split(' ');
                            foreach (string item in spliter)
                            {

                                if (counterOfSplit == 0)
                                {
                                    weather_main = weather_main + " " + item[0].ToString().ToUpper() + item.Substring(1);
                                    counterOfSplit = 1;
                                }
                                else
                                {
                                    weather_main = weather_main + " " + item;
                                }
                            }
                        }
                    }
                }



                //try
                //{

                //    path3 = path2 + $"clothes";
                //    counter = rd.Next(1, 4);
                //    counterr = rdr.Next(4 , 7);

                //    if (Directory.Exists(path3))
                //    {

                //        if (Directory.Exists(path2 + $"clothes\\Female\\{Convert.ToString(model1.Weather[0].Id)[0]}\\{model1.Weather[0].Main }") && Directory.Exists(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}\\{model1.Weather[0].Main }") && Directory.Exists(path2 + $"clothes\\General\\{Convert.ToString(model1.Weather[0].Id)[0]}\\{model1.Weather[0].Main }"))
                //        {
                //            woman_clothes = Path.Combine(path2 + $"clothes\\Female\\{Convert.ToString(model1.Weather[0].Id)[0]}\\{model1.Weather[0].Main }", $"pic{counter}.jpg");
                //            man_clothes = Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}\\{model1.Weather[0].Main }", $"pic{counter}.jpg");

                //            if (Directory.Exists(Path.Combine(path2 + $"clothes\\General\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg")))
                //            {
                //                first_extra_clothes = Path.Combine(path2 + $"clothes\\General\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg");
                //            }
                //            else
                //            {
                //                first_extra_clothes = Path.Combine(path2 + $"clothes\\General", "pic200.jpg");
                //                isexit = true;
                //            }

                //            if (Directory.Exists(Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg")))
                //            {
                //                second_extra_clothes = Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg");
                //            }
                //            else if (isexit == false)
                //            {
                //                second_extra_clothes = Path.Combine(path2 + $"clothes\\General", "pic200.jpg");
                //                isexit = true;
                //            }

                //            if (Directory.Exists(Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg")))
                //            {
                //                third_extra_clothes = Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg");
                //            }
                //            else if (isexit == false)
                //            {
                //                third_extra_clothes = Path.Combine(path2 + $"clothes\\General", "pic200.jpg");
                //                isexit = true;
                //            }

                //            approximatly_main = true;
                //        }

                //        if (Directory.Exists(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}") && approximatly_main == false)
                //        {
                //            man_clothes = Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg");
                //            woman_clothes = Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counterr}.jpg");
                //        }

                //        else
                //            Directory.CreateDirectory(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}");


                //        if (Directory.Exists(path2 + $"clothes\\General\\{Convert.ToString(model1.Weather[0].Id)[0]}") && approximatly_main == false)
                //        {
                //            if (Directory.Exists(Path.Combine(path2 + $"clothes\\General\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg")))
                //            {
                //                first_extra_clothes = Path.Combine(path2 + $"clothes\\General\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg");
                //            }
                //            else
                //            {
                //                first_extra_clothes = Path.Combine(path2 + $"clothes\\General", "pic200.jpg");
                //                isexit = true;
                //            }

                //            if (Directory.Exists(Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg")))
                //            {
                //                second_extra_clothes = Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg");
                //            }
                //            else if (isexit == false)
                //            {
                //                second_extra_clothes = Path.Combine(path2 + $"clothes\\General", "pic200.jpg");
                //                isexit = true;
                //            }

                //            if (Directory.Exists(Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic2.jpg")))
                //            {
                //                third_extra_clothes = Path.Combine(path2 + $"clothes\\Male\\{Convert.ToString(model1.Weather[0].Id)[0]}", $"pic{counter}.jpg");
                //            }
                //            else if (isexit == false)
                //            {
                //                third_extra_clothes = Path.Combine(path2 + $"clothes\\General", "pic200.jpg");
                //                isexit = true;
                //            }
                //        }
                //        else
                //        {
                //            Directory.CreateDirectory(path2 + $"clothes\\General\\{Convert.ToString(model1.Weather[0].Id)[0]}");
                //        }



                //        //if (Directory.Exists(path2 + $"clothes\\Female\\{Convert.ToString(model1.Weather[0].Id)[0]}") && approximatly_main == false)
                //        //else
                //        //    Directory.CreateDirectory(path2 + $"clothes\\Female\\{weather_main.Substring(1, weather_main.Length - 1)}");


                //    }
                //    else
                //    {
                //        Directory.CreateDirectory(path2 + $"clothes");
                //    }

                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Wrong with pic");
                //}




            }
            catch (Exception)
            {

                MessageBox.Show("Something wrong with your city");
            }


            IsBusy = false;



        }

        private async void refresh_cmd()
        {
            //current_time = DateTime.Now;
            //time = Convert.ToString(current_time);

            //string appid = "1de7c89b398a688cd2e5f45782df243f";
            //string city = "Ashgabat";
            //try
            //{
            //    HttpResponseMessage response = await httpClient.GetAsync($@"data/2.5/weather?q={city}&appid={appid}");
            //    string str = response.Content.ReadAsStringAsync().Result;
            //    RootObject model1 = JsonConvert.DeserializeObject<RootObject>(str);

            //    current_country = model1.Sys.Country;
            //    temperature = Convert.ToInt32(model1.Main.Temp - 273.15);
            //    min_temperatur = Convert.ToInt32(model1.Main.TempMin - 273.15);
            //    max_temperatur = Convert.ToInt32(model1.Main.TempMax - 273.15);
            //    real_feel = "RealFeel" + "®" + ((Convert.ToInt32(model1.Main.FeelsLike - 273.15)).ToString());
            //    pressure = (model1.Main.Pressure).ToString() + "kPa";
            //    visibility = (model1.Visibility / 1000).ToString() + "km";
            //    wind = (model1.Wind.Speed).ToString() + "m/s";
            //    humidity = (model1.Main.Humidity).ToString() + "%";
            //    temp_max = Convert.ToInt32(model1.Main.TempMax - 273.15);
            //    temp_min = Convert.ToInt32(model1.Main.TempMin - 273.15);
            //    coord_lon = model1.Coord.Lon;
            //    coord_lat = model1.Coord.Lat;




            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void OnViewLoadedCommand_cmd()
        {
            NavigationService.Navigate("View1", null, this);
        }

        private void details_cmd()
        {
            NavigationService.Navigate("View2" , null , this);
        }
    }
}
