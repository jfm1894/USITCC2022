using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USITCC2022
{

  
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public const string UserFilePath = "E:\\programming\\USITCC2022\\USITCC2022\\Credentials.json";
        public const string AdminFilePath = "E:\\programming\\USITCC2022\\USITCC2022\\AdminCredentials.json";
        public const string DataFilePath = "E:\\programming\\USITCC2022\\USITCC2022\\GrandSlamInformation.json";
        public static string json = File.ReadAllText(UserFilePath);
        public static List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
        public static string adminjson = File.ReadAllText(AdminFilePath);
        public static List<SuperUser> admins = JsonConvert.DeserializeObject<List<SuperUser>>(adminjson);
        public static string datajson = File.ReadAllText(DataFilePath);
        public static List<TournamentRecord> data = JsonConvert.DeserializeObject<List<TournamentRecord>>(datajson);

      
        [STAThread]
        static void Main()
        {
            //Run app
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
