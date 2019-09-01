using System;
using System.IO;
using System.Windows.Forms;

namespace Seralize.Helpers
{
    public class Tools
    {
        public static FileStream Stream(string path)
        {
            FileStream stream = default;
            try
            {
                stream= new FileStream(path, FileMode.OpenOrCreate);
                return stream;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return stream;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                return stream;
               
            }
            catch (PathTooLongException ex)
            {
                MessageBox.Show(ex.Message);
                return stream;
            }
            catch(DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return stream;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                return stream;
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message);
                return stream;
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show(ex.Message);
                return stream;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return stream;
            }
        }
    }
}
