using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms_CardView.Model;

namespace Xamarin.Forms_CardView.ViewModel
{
    public class CardDataViewModel
    {
        public IList<CardDataModel> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }

        public CardDataViewModel()
        {
            CardDataCollection = new List<CardDataModel>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            for (var i = 0; i < 10; i++)
            {
                var cardData = new CardDataModel()
                {
                    Title = "CardRow-No" + i,
                    Owner = "Card-No" + i,
                    AlertColor = i % 2 == 0 ? Color.Green : Color.Blue,
                };
                CardDataCollection.Add(cardData);
            }
        }
    }
}
