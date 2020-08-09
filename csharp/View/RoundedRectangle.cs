using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace uCodeCards
{
	public class GraphicHelpers {
		
		public static GraphicsPath MakeRoundedRect(
		    RectangleF rect, float xradius, float yradius,
		    bool round_ul, bool round_ur, bool round_lr, bool round_ll)
		{
		    // Make a GraphicsPath to draw the rectangle.
		    PointF point1, point2;
		    GraphicsPath path = new GraphicsPath();
		
		    // Upper left corner.
		    if (round_ul)
		    {
		        RectangleF corner = new RectangleF(
		            rect.X, rect.Y,
		            2 * xradius, 2 * yradius);
		        path.AddArc(corner, 180, 90);
		        point1 = new PointF(rect.X + xradius, rect.Y);
		    }
		    else point1 = new PointF(rect.X, rect.Y);
		
		    // Top side.
		    if (round_ur)
		        point2 = new PointF(rect.Right - xradius, rect.Y);
		    else
		        point2 = new PointF(rect.Right, rect.Y);
		    path.AddLine(point1, point2);
		
		    // Upper right corner.
		    if (round_ur)
		    {
		        RectangleF corner = new RectangleF(
		            rect.Right - 2 * xradius, rect.Y,
		            2 * xradius, 2 * yradius);
		        path.AddArc(corner, 270, 90);
		        point1 = new PointF(rect.Right, rect.Y + yradius);
		    }
		    else point1 = new PointF(rect.Right, rect.Y);
		
		    // Right side.
		    if (round_lr)
		        point2 = new PointF(rect.Right, rect.Bottom - yradius);
		    else
		        point2 = new PointF(rect.Right, rect.Bottom);
		    path.AddLine(point1, point2);
		
		    // Lower right corner.
		    if (round_lr)
		    {
		        RectangleF corner = new RectangleF(
		            rect.Right - 2 * xradius,
		            rect.Bottom - 2 * yradius,
		            2 * xradius, 2 * yradius);
		        path.AddArc(corner, 0, 90);
		        point1 = new PointF(rect.Right - xradius, rect.Bottom);
		    }
		    else point1 = new PointF(rect.Right, rect.Bottom);
		
		    // Bottom side.
		    if (round_ll)
		        point2 = new PointF(rect.X + xradius, rect.Bottom);
		    else
		        point2 = new PointF(rect.X, rect.Bottom);
		    path.AddLine(point1, point2);
		
		    // Lower left corner.
		    if (round_ll)
		    {
		        RectangleF corner = new RectangleF(
		            rect.X, rect.Bottom - 2 * yradius,
		            2 * xradius, 2 * yradius);
		        path.AddArc(corner, 90, 90);
		        point1 = new PointF(rect.X, rect.Bottom - yradius);
		    }
		    else point1 = new PointF(rect.X, rect.Bottom);
		
		    // Left side.
		    if (round_ul)
		        point2 = new PointF(rect.X, rect.Y + yradius);
		    else
		        point2 = new PointF(rect.X, rect.Y);
		    path.AddLine(point1, point2);
		
		    // Join with the start point.
		    path.CloseFigure();
		
		    return path;
		}
	}
}
