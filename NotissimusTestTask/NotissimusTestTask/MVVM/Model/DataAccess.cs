using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Xamarin.Forms;


namespace NotissimusTestTask.MVVM.Model
{
    public class DataAccess
    {
        public async Task<Stream> GetXmlStreamFromUrlAsync(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;
            return response.GetResponseStream();
        }

        public List<Offer> DeserializeOffers(Stream response)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(YmlCatalog));
            YmlCatalog deserializedCatalog;

            using (StreamReader reader = new StreamReader(response, Encoding.GetEncoding(1251)))
            {
                deserializedCatalog = serializer.Deserialize(reader) as YmlCatalog;
            }
            return deserializedCatalog.Shop.Offers.OfferList;
        }
    }
}
