﻿using ImageMagick;

namespace OrnekUygulama.Handlers
{
	public class ImageHandler
	{
		public RequestDelegate Handler(string filePath) //HHTP isteğini işlemek için bir delege
		{
			return async c =>
			{
				FileInfo fileInfo = new FileInfo($"{filePath}\\{c.Request.RouteValues["imageName"].ToString()}");
				using MagickImage magick = new MagickImage(fileInfo);

				int width = magick.Width; int height = magick.Height;

				if (!string.IsNullOrEmpty(c.Request.Query["w"].ToString()))
				{
					width = int.Parse(c.Request.Query["w"].ToString());
				}
				if (!string.IsNullOrEmpty(c.Request.Query["h"].ToString()))
				{
					height = int.Parse(c.Request.Query["h"].ToString());
				}

				magick.Resize(width, height);

				var buffer = magick.ToByteArray();
				c.Response.Clear();
				c.Response.ContentType = string.Concat("image/", fileInfo.Extension.Replace(".", ""));

				await c.Response.Body.WriteAsync(buffer, 0, buffer.Length);
				await c.Response.WriteAsync(filePath);
			};

		}
	}
}
