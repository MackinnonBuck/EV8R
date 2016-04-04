using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV8R
{
    class ImageButton : PictureBox
    {
        /// <summary>
        /// The image to be displayed when the mouse is away.
        /// </summary>
        [Category("Appearance")]
        [Description("The image to be displayed when the mouse is away.")]
        public Image AwayImage { get; set; }

        /// <summary>
        /// The image to be displayed when the mouse is hovering over the control.
        /// </summary>
        [Category("Appearance")]
        [Description("The image to be displayed when the mouse is hovering over the control.")]
        public Image HoveringImage { get; set; }

        /// <summary>
        /// The image to be displayed when the mouse is pressing the control.
        /// </summary>
        [Category("Appearance")]
        [Description("The image to be displayed when the mouse is pressing the control.")]
        public Image PressedImage { get; set; }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public ImageButton()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Sets the initial image to the away image mode.
        /// </summary>
        protected override void InitLayout()
        {
            BackgroundImage = AwayImage;
            base.InitLayout();
        }

        /// <summary>
        /// Changes the component's image when the mouse is pressed on the control.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            BackgroundImage = PressedImage;
            base.OnMouseDown(e);
        }

        /// <summary>
        /// Changes the component's image when the mouse is released on the control.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            BackgroundImage = HoveringImage;
            base.OnMouseUp(e);
        }

        /// <summary>
        /// Changes the component's image when the mouse enters the control.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            BackgroundImage = HoveringImage;
            base.OnMouseEnter(e);
        }

        /// <summary>
        /// Changes the component's image when the mouse leaves the control.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            BackgroundImage = AwayImage;
            base.OnMouseLeave(e);
        }
    }
}
