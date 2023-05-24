using OOP_LAB_4.figures;
namespace OOP_LAB_4.factory
{
    public class ShapeArray
    {
        public List<Shape> shapes = new List<Shape>();
       
        public void loadShapes(string filename, ShapeFactory factory)
        {

            if (File.Exists(filename))
            {
                using StreamReader reader = new StreamReader(filename);


                Shape shape;
                string line;
                int count;
                count = Convert.ToInt32(reader.ReadLine());

                for (int i = 0; i < count; ++i)
                {
                    line = reader.ReadLine();
                    shape = factory.create(Convert.ToChar(line));
                    if (shape != null)
                    {
                        shape.load(reader, factory);
                        shapes.Add(shape);
                    }
                }
            }
        }

        public void saveShapes(string filename)
        {
            using StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine(shapes.Count);
            for (int i = 0; i < shapes.Count; ++i)
            {
                shapes[i].save(writer);
            }
        }
    }
}
