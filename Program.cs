using System;

namespace HomeworkValueTypeAndReferensType
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricShapeStruct one = new GeometricShapeStruct() { CountFaces = 1, LengthFaces = 2, AreaShape = 3 };
            GeometricShapeStruct two = CalculateOriginalAreaStruct(ref one);
            Console.WriteLine(one.AreaShape);
            Console.WriteLine(two.AreaShape);
            Console.ReadKey();
        }

        public GeometricShape CalculateNewArea(GeometricShape originalShape)
        {
            GeometricShape secondShape = new GeometricShape() { CountFaces = originalShape.CountFaces, LengthFaces = originalShape.LengthFaces };
            secondShape.AreaShape = (int)((Math.Pow(secondShape.LengthFaces, 2) * secondShape.CountFaces) /
                (4 * Math.Tan(Math.PI / secondShape.CountFaces)));

            return secondShape;
        }

        public GeometricShape CalculateOriginalArea(GeometricShape originalShape)
        {
            originalShape.AreaShape = (int)((Math.Pow(originalShape.LengthFaces, 2) * originalShape.CountFaces) /
                (4 * Math.Tan(Math.PI / originalShape.CountFaces)));

            return originalShape;
        }

        public GeometricShapeStruct CalculateNewAreaStruct(GeometricShapeStruct originalShapeStruct)
        {
            originalShapeStruct.AreaShape = (int)((Math.Pow(originalShapeStruct.LengthFaces, 2) * originalShapeStruct.CountFaces) /
            (4 * Math.Tan(Math.PI / originalShapeStruct.CountFaces)));

            return originalShapeStruct;
        }

        public static GeometricShapeStruct CalculateOriginalAreaStruct(ref GeometricShapeStruct originalShapeStruct)
        {
            originalShapeStruct.AreaShape = (int)((Math.Pow(originalShapeStruct.LengthFaces, 2) * originalShapeStruct.CountFaces) /
            (4 * Math.Tan(Math.PI / originalShapeStruct.CountFaces)));

            return originalShapeStruct;
        }
    }
}
