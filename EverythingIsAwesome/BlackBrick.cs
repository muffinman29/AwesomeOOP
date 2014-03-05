using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsAwesome
{
    class BlackBrick : LEGO, IBrick
    {
        public BlackBrick()
        {
            BrickColor = Color.Black;
            BrickHeight = 30;
            BrickWidth = 40;
        }

        private Color _brickColor;
        public System.Drawing.Color BrickColor
        {
            get
            {
                return _brickColor;
            }
            set
            {
                _brickColor = value;
            }
        }

        private int _brickHeight;
        public int BrickHeight
        {
            get
            {
                return _brickHeight;
            }
            set
            {
                _brickHeight = value;
            }
        }

        private int _brickWidth;
        public int BrickWidth
        {
            get
            {
                return _brickWidth;
            }
            set
            {
                _brickWidth = value;
            }
        }

        public string BricksAreAwesome()
        {
            return "Black bricks are awesome!";
        }

        public string EverythingIsAwesome()
        {
            return "Everything is awesome if you are a black brick!";
        }
    }
}
