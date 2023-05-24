using OOP_LAB_4.Decorators;
using OOP_LAB_4.factory;

namespace OOP_LAB_4.figures
{
    public class CGroup : Shape
    {
        public List<Shape> shapes { get; set; }

        public CGroup() : base()
        {
            shapes = new List<Shape>();
            name = CONST_SHAPE.Group;
        }

        public CGroup(Shape group) : base(group) 
        {
            shapes = new List<Shape>();
            if(group.getName() == CONST_SHAPE.Group)
            {
                foreach(Shape shape in ((CGroup)group).shapes)
                {
                    shapes.Add(shape);
                }
            }
            name = CONST_SHAPE.Group;
        }

        public override void load(StreamReader reader, ShapeFactory factory)
        {
            int count = Convert.ToInt32(reader.ReadLine());  
            for(int i = 0; i < count; i++) 
            {
                Shape shape = factory.create(Convert.ToChar(reader.ReadLine()));
                if(shape != null)
                {
                    shape.load(reader, factory);
                    shapes.Add(shape);
                }
            }
        }
        public override void save(StreamWriter writer)
        {
            writer.WriteLine(name);
            writer.WriteLine(shapes.Count);
            foreach(Shape shape in shapes)
            {
                shape.save(writer);
            }
        }
        public void add(Size imageSize, Shape shape)
        {
            shape = new UnMarked(shape);
            shapes.Add(shape);
            new_size(imageSize);
        }
        public void new_size(Size imageSize)
        {
            Point left_up = new(imageSize.Width, imageSize.Height);
            Point right_bottom = new Point(0, 0);

            foreach (Shape shape in shapes)
            {
                Point new_left_up = shape.getPoint();
                Point new_right_bottom = new(new_left_up.X + shape.getSize().Width, new_left_up.Y + shape.getSize().Height);
                if (left_up.X > new_left_up.X)
                {
                    left_up.X = new_left_up.X;
                }
                if (left_up.Y > new_left_up.Y)
                {
                    left_up.Y = new_left_up.Y;
                }
                if (new_right_bottom.X > right_bottom.X)
                {
                    right_bottom.X = new_right_bottom.X;
                }
                if (new_right_bottom.Y > right_bottom.Y)
                {
                    right_bottom.Y = new_right_bottom.Y;
                }
                
            }

            p0 = left_up;
            shapeSize= new Size(right_bottom.X - left_up.X, right_bottom.Y - left_up.Y);

            move(imageSize, 0, 0);
        }
        public override void move(Size imageSize, int dx, int dy)
        {
            int temp_dx = dx, temp_dy = dy;
            Point old_p0 = p0;

            base.move(imageSize, temp_dx, temp_dy);

            temp_dx = p0.X - old_p0.X;
            temp_dy = p0.Y - old_p0.Y;

            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].move(imageSize, temp_dx, temp_dy);
            }
        }
        public override void setColor(Color new_color)
        {
            foreach(Shape shape in shapes)
            {
                shape.setColor(new_color);
            }
        }
        public override void Draw(Graphics g)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
        }
        public override bool inShape(int x, int y)
        {
            foreach(Shape shape in shapes)
                if(shape.inShape(x, y))
                    return true;

            return false;
        }
        public override void resize(Size imageSize, int delta)
        {
            base.resize(imageSize, delta);
            foreach(Shape shape in shapes)
            {
                shape.resize(imageSize, delta);
            }
            new_size(imageSize);
        }
    }
}
