using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyCar.Data;
using MyCar.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelperDroid))]
namespace MyCar.Droid
{
    public class FileHelperDroid : IFileHelper
    {
        public string GetLocalFilepath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}