using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ObjLibrary
{
    public class FileLogger
    {
        #region fields
        
        const string str_data_dir = @"c:\acs_data";
        const string str_data_file = "acs_data.txt";


        #endregion

        #region properties

        string DATA_FILE_PATH
        {
            get { return make_data_file_path(); }
        }


        #endregion

        #region cstor

        public FileLogger()
        {
        }

        #endregion

        #region functions

        string make_data_file_path()
        {
            return String.Format("{0}\\{1} - {2}", str_data_dir, DateTime.Now.ToShortDateString(), str_data_file);
        }


        #region Exceptions
        // Исключения:
        //   T:System.UnauthorizedAccessException:
        //     Отказано в доступе.
        //
        //   T:System.ArgumentException:
        //     path пусто. – или –path содержит имя системного устройства (com1, com2 и т. д.).
        //
        //   T:System.ArgumentNullException:
        //     Параметр path имеет значение null.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     Указанный путь недопустим (например, он соответствует неподключенному диску).
        //
        //   T:System.IO.IOException:
        //     Параметр path включает неверный или недопустимый синтаксис имени файла, имени
        //     каталога или метки тома.
        //
        //   T:System.IO.PathTooLongException:
        //     Длина указанного пути, имени файла или обоих параметров превышает установленное
        //     в системе максимальное значение.Например, для платформ на основе Windows длина
        //     пути не должна превышать 248 символов, а имена файлов не должны содержать более
        //     260 символов.
        //
        //   T:System.Security.SecurityException:
        //     У вызывающего объекта отсутствует необходимое разрешение. 
        #endregion

        public bool WriteListOfStrings(List<AcsDataMessage> list_adm_)
        {
            bool result;

            if (!Directory.Exists(str_data_dir))
            {
                try
                {
                    #region Exceptions

                    //IOException
                    //The directory specified by path is a file.
                    //- or -
                    //The network name is not known.

                    //UnauthorizedAccessException
                    //The caller does not have the required permission.

                    //ArgumentException
                    //path is a zero - length string, contains only white space, or contains one or more invalid characters.You can query for invalid characters by using the GetInvalidPathChars method.
                    // - or -
                    // path is prefixed with, or contains, only a colon character(:).

                    // ArgumentNullException
                    //path is null.

                    //PathTooLongException
                    //The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows - based platforms, paths must be less than 248 characters and file names must be less than 260 characters.

                    //  DirectoryNotFoundException
                    //  The specified path is invalid (for example, it is on an unmapped drive).

                    //  NotSupportedException
                    //path contains a colon character(:) that is not part of a drive label("C:\"). 

                    #endregion

                    Directory.CreateDirectory(str_data_dir);
                    result = true;
                }
                catch (Exception e)
                {
                    result = false;
                }

            }
            else
            {
                result = true;
            }

            #region old
            //using (StreamWriter sr = new StreamWriter(DATA_FILE_PATH, true))
            //{
            //    foreach (AnQueueString q_str_ in list_q_str_)
            //    {
            //        sr.WriteLine(q_str_.DATE_TIME_AND_DATA_AS_STRING);
            //    }
            //} 
            #endregion

            if (result == true)
            {
                StreamWriter sr = null;

                try
                {
                    #region Exceptions

                    //UnauthorizedAccessException
                    //Access is denied.

                    //ArgumentException
                    //path is empty.
                    //- or -
                    //path contains the name of a system device(com1, com2, and so on).

                    //ArgumentNullException
                    //path is null.

                    //DirectoryNotFoundException
                    //The specified path is invalid (for example, it is on an unmapped drive).

                    //IOException
                    //path includes an incorrect or invalid syntax for file name, directory name, or volume label syntax.

                    //PathTooLongException
                    //The specified path, file name, or both exceed the system - defined maximum length.For example, on Windows - based platforms, paths must not exceed 248 characters, and file names must not exceed 260 characters.

                    //SecurityException
                    //The caller does not have the required permission. 

                    #endregion

                    sr = new StreamWriter(DATA_FILE_PATH, true);

                    foreach (AcsDataMessage adm in list_adm_)
                    {
                        #region Exceptions

                        //ObjectDisposedException
                        //The TextWriter is closed.

                        //IOException
                        //An I/ O error occurs.  

                        #endregion

                        sr.WriteLine(adm.FILE_LOG_STR);
                    }

                    result = true;
                }
                catch (Exception e)
                {
                    result = false;
                }

                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }

            return result;

        }

        #endregion
    }
}
