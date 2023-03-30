using Newtonsoft.Json;
using NotissimusTestTask.MVVM.Model;
using NotissimusTestTask.MVVM.View;
using Xamarin.Forms;
using System;
using NotissimusTestTask.MVVM.ViewModel;

namespace NotissimusTestTask.Commands
{
    public class ShowSerializedOfferPageCommand : CommandBase
    {
        public override async void Execute(object? parameter)
        {
            var selectedOffer = parameter as Offer;

            if (selectedOffer == null)
            {
                return;
            }

            string serializedOffer = JsonConvert.SerializeObject(selectedOffer,
                            Formatting.Indented,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

            SerilizedToJsonOfferView newPage = CreateNewSerializedOfferView(serializedOffer);

            await App.Current.MainPage.Navigation.PushAsync(newPage);
        }

        private SerilizedToJsonOfferView CreateNewSerializedOfferView(string serializedOffer)
        {
            SerializedToJsonOfferViewModel viewModel = new SerializedToJsonOfferViewModel();
            viewModel.SerializedOffer = serializedOffer;

            SerilizedToJsonOfferView newPage = new SerilizedToJsonOfferView();
            newPage.BindingContext = viewModel;
            return newPage;
        }
    }
}
