using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomMessageBox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageBox : PopupPage
    {
        public MessageBox(String title, String message)
        {
            InitializeComponent();
            TitleTxt.Text = title;
            MsgTxt.Text = message;
        }

        //Esta es la clase de event que puede ser llamado desde otra parte del codigo
        public EventHandler<DialogResult> onDialogClosed;

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    App.Current.MainPage.Navigation.PopPopupAsync(true);
        //}

        private void CancelBtn_Clicked(object sender, EventArgs e)
        {
            //Al darle ok invoca al metodo dandole el mensaje.
            onDialogClosed?.Invoke(this, new DialogResult { Success = true, Message = "User clicks CANCEL" });
            //popup se cierra
            App.Current.MainPage.Navigation.PopPopupAsync(true);
        }

        private void okBtn_Clicked(object sender, EventArgs e)
        {
            //Al darle ok invoca al metodo dandole el mensaje.
            onDialogClosed?.Invoke(this, new DialogResult { Success = true, Message = "User clicks OK" });
            //popup se cierra
            App.Current.MainPage.Navigation.PopPopupAsync(true);
        }
    }

    public class DialogResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }
}