﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerApis.Apis.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerApis.Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PublicacionesPage : ContentPage
	{
		public PublicacionesPage ()
		{
			InitializeComponent ();
            CargarPublicaciones();
		}

        private async Task CargarPublicaciones()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.1.59");

            var request = await client.GetAsync("/PublicacionApis/api/publicacion");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                listPublicaciones.ItemsSource = response;
             

            }
        }






    }
}