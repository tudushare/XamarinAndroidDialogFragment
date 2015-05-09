using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TDDialogDemo
{
	[Activity (Label = "TDDialogDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.btnShowDialog);
			
			button.Click += delegate {
				// show the dialog
				FragmentTransaction transaction = FragmentManager.BeginTransaction();
				TDDialog dialog = new TDDialog();
				dialog.Show(transaction, "dialog fragment");
			};
		}
	}
}


