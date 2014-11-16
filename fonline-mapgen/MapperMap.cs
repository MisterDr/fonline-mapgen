﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;

using FOCommon.Parsers;
using FOCommon.Maps;
using FOCommon.Items;
using FOCommon.Graphic;

namespace fonline_mapgen
{
    public partial class MapperMap : FOMap
    {
        public string Name;
        public FOHexMap HexMap { get; private set; }

        internal MapperMap( FOMap map, bool glMode)
        {
            this.Header = map.Header;
            this.Tiles = map.Tiles;
            this.Objects = map.Objects;

            this.InitHexMap(glMode);
        }

        internal MapperMap(bool glMode)
            : base()
        {
            this.Header.MaxHexX = this.Header.MaxHexY = 50;
            this.Header.WorkHexX = this.Header.WorkHexY = (ushort)(this.Header.WorkHexY / 2);

            this.InitHexMap(glMode);
        }

        public PointF GetEdgeCoords(FOHexMap.Direction dir)
        {
            List<Point> hexes = new List<Point>();
            foreach (var tile in this.Tiles)
            {
                hexes.Add(new Point(tile.X, tile.Y));
            }
            return this.HexMap.GetEdgeCoords(hexes, dir);
        }

        private void InitHexMap(bool glMode)
        {
            this.HexMap = new FOHexMap(new Size(this.Header.MaxHexX, this.Header.MaxHexY));

            PointF baseOffset = new PointF(0, 0);
            if (!glMode)
            {
                Tile rightTile = this.Tiles[0];

                List<Point> hexes = new List<Point>();
                foreach (var tile in this.Tiles)
                {
                    hexes.Add(new Point(tile.X, tile.Y));
                }

                PointF edgeLeft = this.HexMap.GetEdgeCoords(hexes, FOHexMap.Direction.Left);
                PointF edgeUp = this.HexMap.GetEdgeCoords(hexes, FOHexMap.Direction.Up);

                baseOffset = new PointF(-edgeLeft.X + 100.0f, edgeUp.Y);
            }
            this.HexMap = new FOHexMap(baseOffset, new Size(this.Header.MaxHexX, this.Header.MaxHexY));
        }

        public static MapperMap Load( string fileName, bool glMode)
        {
            FOMapParser parser = new FOMapParser( fileName );
            if( parser.Parse() )
                return (new MapperMap( parser.Map, glMode ));

            return (null);
        }
    }
}
