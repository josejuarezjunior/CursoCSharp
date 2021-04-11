using ClassesAbstratas.Entities.Enums;

namespace ClassesAbstratas.Entities
{

    /* Como essa classe possui um método abstrato,
     * a mesma obrigatoriamente deve ser uma classe
     * abstrata!
    */
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        //A palavra "abstract" indica que se trata de um método abstrato.
        public abstract double Area();
    }
}