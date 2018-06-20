using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySDK.SceneItems
{
    public class ImageItem : ISceneItem
    {
        public Image Image { get; set;}

        private float xOffset;
        private float yOffset;

        public ImageItem()
        {
            UserInput.Instance.MouseScroll += Instance_MouseScroll;
        }
        ~ImageItem()
        {
            UserInput.Instance.MouseScroll -= Instance_MouseScroll;
        }
        private void Instance_MouseScroll(MouseEventArgs args)
        {
            yOffset+=args.ScrollY;
            if (yOffset < 0)
                yOffset = 0;
            
        }

        public Size GetDisplaySize()
        {
            throw new NotImplementedException();
        }

        public Point GetScaledGazeCoordinates(IEyeTracker tracker)
        {
            throw new NotImplementedException();
        }

        public Point GetScrollOffset()
        {
            throw new NotImplementedException();
        }

        public void RenderToSurface(Size bounds, Graphics graphics)
        {
            //Do some scalling
            graphics.DrawImage(Image, new RectangleF(0, 0, bounds.Width, bounds.Height),
                new RectangleF(0, yOffset, Image.Width, Image.Height), GraphicsUnit.Pixel);
        }
    }
}
