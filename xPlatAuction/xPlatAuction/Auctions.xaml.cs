using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices;

using Xamarin.Forms;

namespace xPlatAuction
{
	public partial class Auctions : ContentPage
	{
		public Auctions ()
		{
			InitializeComponent ();
		}

		public async void Button_Click (object sender, EventArgs e)
		{
			MobileServiceClient client =
				new MobileServiceClient ("http://win8-pc/xPlatAuction");
				var todoItems = await client.GetTable<ToDoItem> ().ReadAsync ();
			message.Text =  "fucked up example code";
 		}
	}

}

