using System;
using Android.App;
using Android.Widget;

namespace TDDialogDemo
{
	public class TDDialog: DialogFragment
	{
		public override Android.Views.View OnCreateView (Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);
			var view = inflater.Inflate (Resource.Layout.tdDialogLayout, container, false);
			var btnCloseDialog = view.FindViewById<Button> (Resource.Id.btnCloseDialog);
			btnCloseDialog.Click += (object sender, EventArgs e) => {
				Dismiss();
			};
			return view;
		}

		public override void OnActivityCreated (Android.OS.Bundle savedInstanceState)
		{
			Dialog.Window.RequestFeature (Android.Views.WindowFeatures.NoTitle); // hide title bar
			base.OnActivityCreated (savedInstanceState);
			Dialog.Window.Attributes.WindowAnimations = Resource.Style.dialog_animation; // add animation
		}
	}
}

