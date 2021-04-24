﻿using HerdarXCumprirContrato.Model.Enums;

namespace HerdarXCumprirContrato.Model.Entities
{   
    abstract class Shape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }
}