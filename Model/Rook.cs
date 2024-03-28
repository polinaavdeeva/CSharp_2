﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Model
{
    public class Rook : Figure
    {
        public Rook(Color color, (int row, int col) position) : base(color, position)
        {
        }

        protected override bool IsMovePossible(int row, int col)
        {
            if (row < 0 || row > 7 || col < 0 || col > 7) return false;
            if (Position.row != row && Position.col != col)
            {
                return false;
            }
            return true;
        }
    }
}
