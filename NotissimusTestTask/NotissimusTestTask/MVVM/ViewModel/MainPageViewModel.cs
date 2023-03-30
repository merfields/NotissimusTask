using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NotissimusTestTask.Commands;
using NotissimusTestTask.MVVM.Model;

namespace NotissimusTestTask.MVVM.ViewModel
{
    public class MainPageViewModel : ObservableObject
    {
        private ObservableCollection<Offer> offers;
        public ObservableCollection<Offer> Offers
        {
            get
            {
                return offers;
            }
            set
            {
                offers = value;
                OnPropertyChanged(nameof(Offers));
            }
        }

        public CommandBase ShowSerializedOfferPageCommand { get; set; }
        public MainPageViewModel()
        {
            ShowSerializedOfferPageCommand = new ShowSerializedOfferPageCommand();

            DataAccess dataAccess = new DataAccess();
            string xmlUrl = "http://partner.market.yandex.ru/pages/help/YML.xml";

            Stream xmlStream = Task.Run(async () => await dataAccess.GetXmlStreamFromUrlAsync(xmlUrl)).Result;

            Offers = new ObservableCollection<Offer>(dataAccess.DeserializeOffers(xmlStream));
        }

    }
}
