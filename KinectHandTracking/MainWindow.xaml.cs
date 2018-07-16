using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace KinectHandTracking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Members

        KinectSensor _sensor;
        MultiSourceFrameReader _reader;
        IList<Body> _bodies;

        //public Ellipse Ellipse { get; private set; }
        public Rectangle Rectangle { get; private set; }

        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion

        private void DrawingRanadTeeth(Rectangle recName,int width,int height,int positionOnXAxis,int positionOnYAxis)
        {
            recName.StrokeThickness = 2;
            recName.Stroke = Brushes.Black;
            recName.Width = width;
            recName.Height = height;
            Canvas.SetLeft(recName, positionOnXAxis);
            Canvas.SetTop(recName, positionOnYAxis);
            //canvas.Children.Add(recName);

        }


        #region Event handlers

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _sensor = KinectSensor.GetDefault();

            if (_sensor != null)
            {
                _sensor.Open();

                _reader = _sensor.OpenMultiSourceFrameReader(FrameSourceTypes.Color | FrameSourceTypes.Depth | FrameSourceTypes.Infrared | FrameSourceTypes.Body);
                _reader.MultiSourceFrameArrived += Reader_MultiSourceFrameArrived;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (_reader != null)
            {
                _reader.Dispose();
            }

            if (_sensor != null)
            {
                _sensor.Close();
            }
        }

        void Reader_MultiSourceFrameArrived(object sender, MultiSourceFrameArrivedEventArgs e)
        {
            var reference = e.FrameReference.AcquireFrame();

            // Color
            using (var frame = reference.ColorFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    camera.Source = frame.ToBitmap();
                }
            }
            
            // Body
            using (var frame = reference.BodyFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    canvas.Children.Clear();

                    _bodies = new Body[frame.BodyFrameSource.BodyCount];

                    frame.GetAndRefreshBodyData(_bodies);


                    #region drawing_ranad

                    Rectangle ranad_teeth1 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth1, 30, 200, 120, 600);
                    canvas.Children.Add(ranad_teeth1);

                    Rectangle ranad_teeth2 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth2, 30, 200, 160, 600);
                    canvas.Children.Add(ranad_teeth2);

                    Rectangle ranad_teeth3 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth3, 30, 200, 200, 600);
                    canvas.Children.Add(ranad_teeth3);

                    Rectangle ranad_teeth4 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth4, 30, 200, 240, 600);
                    canvas.Children.Add(ranad_teeth4);

                    Rectangle ranad_teeth5 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth5, 30, 200, 280, 600);
                    canvas.Children.Add(ranad_teeth5);

                    Rectangle ranad_teeth6 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth6, 30, 200, 320, 600);
                    canvas.Children.Add(ranad_teeth6);

                    Rectangle ranad_teeth7 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth7, 30, 200, 360, 600);
                    canvas.Children.Add(ranad_teeth7);

                    Rectangle ranad_teeth8 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth8, 30, 200, 400, 600);
                    canvas.Children.Add(ranad_teeth8);

                    Rectangle ranad_teeth9 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth9, 30, 200, 440, 600);
                    canvas.Children.Add(ranad_teeth9);

                    Rectangle ranad_teeth10 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth10, 30, 200, 480, 600);
                    canvas.Children.Add(ranad_teeth10);

                    Rectangle ranad_teeth11 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth11, 30, 200, 520, 600);
                    canvas.Children.Add(ranad_teeth11);

                    Rectangle ranad_teeth12 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth12, 30, 200, 560, 600);
                    canvas.Children.Add(ranad_teeth12);

                    Rectangle ranad_teeth13 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth13, 30, 200, 600, 600);
                    canvas.Children.Add(ranad_teeth13);

                    Rectangle ranad_teeth14 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth14, 30, 200, 640, 600);
                    canvas.Children.Add(ranad_teeth14);

                    Rectangle ranad_teeth15 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth15, 30, 200, 680, 600);
                    canvas.Children.Add(ranad_teeth15);

                    Rectangle ranad_teeth16 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth16, 30, 200, 720, 600);
                    canvas.Children.Add(ranad_teeth16);

                    Rectangle ranad_teeth17 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth17, 30, 200, 760, 600);
                    canvas.Children.Add(ranad_teeth17);

                    Rectangle ranad_teeth18 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth18, 30, 200, 800, 600);
                    canvas.Children.Add(ranad_teeth18);

                    Rectangle ranad_teeth19 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth19, 30, 200, 840, 600);
                    canvas.Children.Add(ranad_teeth19);

                    Rectangle ranad_teeth20 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth20, 30, 200, 880, 600);
                    canvas.Children.Add(ranad_teeth20);

                    Rectangle ranad_teeth21 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth21, 30, 200, 920, 600);
                    canvas.Children.Add(ranad_teeth21);

                    Rectangle ranad_teeth22 = new Rectangle();
                    DrawingRanadTeeth(ranad_teeth22, 30, 200, 960, 600);
                    canvas.Children.Add(ranad_teeth22);

                    #endregion

                    #region drawing_circle_example

                    //Draw the drum
                    //Ellipse circle1 = new Ellipse();
                    //circle1.StrokeThickness = 5;
                    //circle1.Stroke = Brushes.Black;

                    //circle1.Width = 140;
                    //circle1.Height = 55;
                    //Canvas.SetLeft(circle1, 120);
                    //Canvas.SetTop(circle1, 600);
                    //canvas.Children.Add(circle1);

                    //Ellipse circle2 = new Ellipse();
                    //circle2.StrokeThickness = 5;
                    //circle2.Stroke = Brushes.Black;
                    //circle2.Width = 180;
                    //circle2.Height = 70;
                    //Canvas.SetLeft(circle2, 270);
                    //Canvas.SetTop(circle2, 605);
                    //canvas.Children.Add(circle2);

                    //Ellipse circle3 = new Ellipse();
                    //circle3.StrokeThickness = 5;
                    //circle3.Stroke = Brushes.Black;
                    //circle3.Width = 180;
                    //circle3.Height = 70;
                    //Canvas.SetLeft(circle3, 410);
                    //Canvas.SetTop(circle3, 620);
                    //canvas.Children.Add(circle3);

                    #endregion

                    foreach (var body in _bodies)
                    {
                        if (body != null)
                        {
                            if (body.IsTracked)
                            {
                                // Find the joints
                                Joint handRight = body.Joints[JointType.HandRight];
                                Joint thumbRight = body.Joints[JointType.ThumbRight];
                                double rightX = handRight.Position.X;
                                double rightY = handRight.Position.Y;

                                Joint handLeft = body.Joints[JointType.HandLeft];
                                Joint thumbLeft = body.Joints[JointType.ThumbLeft];
                                double leftX = handLeft.Position.X * (-100);
                                double leftY = handLeft.Position.Y * 100;
                                double leftZ = handLeft.Position.Z * 100;
                                // Draw hands and thumbs


                                canvas.DrawHand(handRight, _sensor.CoordinateMapper);
                                canvas.DrawHand(handLeft, _sensor.CoordinateMapper);
                                //canvas.DrawThumb(thumbRight, _sensor.CoordinateMapper);
                                //canvas.DrawThumb(thumbLeft, _sensor.CoordinateMapper);

                                double hitFirstMax = 70;
                                double hitFirstMin = 60;

                                //set direction
                                double direction = 1;

                                if (leftY > 5)
                                {
                                    direction = 1;
                                }
                                else
                                {
                                    direction = 0;
                                }


                                // Find the hand states
                                string rightHandState = "-";
                                string leftHandState = "-";
                                
                                rightHandState = System.Convert.ToString(leftX);
                                leftHandState = System.Convert.ToString(leftY);





                                tblRightHandState.Text = rightHandState;
                                tblLeftHandState.Text = leftHandState;


                                if ((leftX <= 107) && (leftX >= 102) && ((leftY >= 7.9) && (leftY <= 10.1)))
                                {
                                    System.Media.SoundPlayer startSound = new System.Media.SoundPlayer(@"C:\Users\USER\Desktop\project thesis kinect\sound\air.wav");
                                    if (direction == 1)
                                    {
                                        startSound.Play();
                                    }
                                }
                                else if ((leftX <= 50) && (leftX >= 40) && ((leftY >= 7.9) && (leftY <= 10.1)))
                                {
                                    System.Media.SoundPlayer midSound = new System.Media.SoundPlayer(@"C:\Users\USER\Desktop\project thesis kinect\sound\bullet.wav");
                                    if(direction == 1)
                                    {
                                        midSound.Play();
                                    }
                                }
                                else if ((leftX <= 30) && (leftX >= 20) && ((leftY >= 7.9) && (leftY <= 10.1)))
                                {
                                    System.Media.SoundPlayer test = new System.Media.SoundPlayer(@"C:\Users\USER\Desktop\project thesis kinect\sound\cry.wav");
                                    if (direction == 1)
                                    {
                                        test.Play();
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}
