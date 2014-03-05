using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsAwesome
{
    class RedBrick : LEGO, IBrick
    {
        public RedBrick()
        {
            BrickColor = Color.Red;
            BrickHeight = 20;
            BrickWidth = 20;
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
            return "Red Bricks are awesome!";
        }

        public string EveryRedBrickIsAwesome()
        {
            return "Everything is awesome if you are a red brick!";
        }
    }
}
