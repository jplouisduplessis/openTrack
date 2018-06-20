using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MySDK
{
    public interface ISceneItem
    {
        /// <summary>
        /// Get the scroll offset percentage
        /// </summary>
        /// <returns></returns>
        Point GetScrollOffset();
        /// <summary>
        /// Get the physical dimensions of the media
        /// </summary>
        /// <returns></returns>
        Size GetDisplaySize();

        /// <summary>
        /// Return coordinates scaled in [0,1] range for display media
        /// </summary>
        /// <param name="tracker"></param>
        /// <returns></returns>
        Point GetScaledGazeCoordinates(IEyeTracker tracker);

        /// <summary>
        /// Render the media in the space provided
        /// </summary>
        /// <param name="bounds">Space available</param>
        /// <param name="graphics">Rendering device</param>
        void RenderToSurface(Size bounds, Graphics graphics);
    }
}
