using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms_CardView.iOS.Renderer;

[assembly: ExportRenderer(typeof(ViewCell), typeof(CustomCellRenderer))]
namespace Xamarin.Forms_CardView.iOS.Renderer
{
    public class CustomCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            cell.SelectionStyle = UITableViewCellSelectionStyle.Gray;
            return cell;
        }
    }
}
