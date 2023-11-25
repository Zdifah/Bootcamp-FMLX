namespace PhotoFilterLib;

public class PhotoProcessor
{
	public delegate void PhotoFilterHandler(Photo photo);
	
	public void Process(string path, PhotoFilterHandler filterHandler)
	{
		Photo photo = Photo.Load(path);
		
		filterHandler?.Invoke(photo);
		photo.Save();
	}
}
