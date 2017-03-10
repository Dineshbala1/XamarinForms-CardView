using System;
using System.Collections.Generic;
using System.Text;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms_CardView.iOS.Renderer;

[assembly: ExportRenderer(typeof(Frame), typeof(CustomFrameRenderer))]
namespace Xamarin.Forms_CardView.iOS.Renderer
{
    public class CustomFrameRenderer : FrameRenderer
    {
        public override void Draw(CGRect rect)
        {
            SetupShadowLayer();
            base.Draw(rect);
        }

        void SetupShadowLayer()
        {
            Layer.CornerRadius = 1; // 5 Default
            if (Element.BackgroundColor == Xamarin.Forms.Color.Default)
            {
                Layer.BackgroundColor = UIColor.White.CGColor;
            }
            else
            {
                Layer.BackgroundColor = Element.BackgroundColor.ToCGColor();
            }

            //Layer.ShadowRadius = 1;
            //Layer.ShadowColor = UIColor.Black.CGColor;
            //Layer.ShadowOpacity = 0.4f;
            //Layer.ShadowOffset = new CGSize(0f, 2.5f);

            Layer.RasterizationScale = UIScreen.MainScreen.Scale;
            Layer.ShouldRasterize = true;
        }
    }
}
