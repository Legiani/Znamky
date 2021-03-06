﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Znamky
{
	public partial class rychloPocet : ContentPage
	{
		List<Znamka> znamka = new List<Znamka>();
		public rychloPocet()
		{
			InitializeComponent();
		}

		public void zpet(object sender, EventArgs args)
		{
			Navigation.PopModalAsync();
		}
		public void pridat(object sender, EventArgs args)
		{
			znamka.Add(new Znamka() { Hodnoceni = Convert.ToInt16(hodnoceni.Text), Vaha = Convert.ToInt16(vaha.Text) });

			double y = znamka.Average(x => x.PravaZnamka());
			System.Diagnostics.Debug.WriteLine(y);
			prumer.Text = Convert.ToString( Math.Round( y, 2)/10);
			ListViewFormatted.ItemsSource = " ";
			ListViewFormatted.ItemsSource = znamka;

		}
	}
}
