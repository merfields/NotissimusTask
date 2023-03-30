using NotissimusTestTask.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NotissimusTestTask.MVVM.ViewModel
{
    public class SerializedToJsonOfferViewModel: ObservableObject
    {
        private string serializedOffer;
        public string SerializedOffer
        {
            get
            {
                return serializedOffer;
            }
            set
            {
                serializedOffer = value;
                OnPropertyChanged(nameof(SerializedOffer));
            }
        }
    }
}
