namespace EmployeesWebApplication.Models
{
    public class JsonReader
    {
        /// <summary>
        /// This method intended to read Data From Json File to a String Format.
        /// </summary>
        /// <param name="fileName">The Json filename.</param>
        /// <returns></returns>
        public string Read(string fileName)
        {
            string root = "wwwroot";
            string folder = "Jsons";
            string path = Path.Combine(
            Directory.GetCurrentDirectory(),
            root,
            folder,
            fileName);

            string jsonResult;
            StreamReader streamReader = new StreamReader(path);
            jsonResult = streamReader.ReadToEnd();
            return jsonResult;
        }
    }
}
