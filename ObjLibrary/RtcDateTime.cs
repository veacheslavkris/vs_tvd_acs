using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjLibrary
{
    public class RtcDateTime
    {

        #region structs Date and Time

        //typedef struct
        //{
        //    uint8_t Hours;            /*!< Specifies the RTC Time Hour.
        //                             This parameter must be a number between Min_Data = 0 and Max_Data = 12 if the RTC_HourFormat_12 is selected.
        //                             This parameter must be a number between Min_Data = 0 and Max_Data = 23 if the RTC_HourFormat_24 is selected  */

        //    uint8_t Minutes;          /*!< Specifies the RTC Time Minutes.
        //                             This parameter must be a number between Min_Data = 0 and Max_Data = 59 */

        //    uint8_t Seconds;          /*!< Specifies the RTC Time Seconds.
        //                             This parameter must be a number between Min_Data = 0 and Max_Data = 59 */

        //    uint8_t TimeFormat;       /*!< Specifies the RTC AM/PM Time.
        //                             This parameter can be a value of @ref RTC_AM_PM_Definitions */

        //    uint32_t SubSeconds;     /*!< Specifies the RTC_SSR RTC Sub Second register content.
        //                             This parameter corresponds to a time unit range between [0-1] Second
        //                             with [1 Sec / SecondFraction +1] granularity */

        //    uint32_t SecondFraction;  /*!< Specifies the range or granularity of Sub Second register content
        //                             corresponding to Synchronous pre-scaler factor value (PREDIV_S)
        //                             This parameter corresponds to a time unit range between [0-1] Second
        //                             with [1 Sec / SecondFraction +1] granularity.
        //                             This field will be used only by HAL_RTC_GetTime function */

        //    uint32_t DayLightSaving;  /*!< Specifies RTC_DayLightSaveOperation: the value of hour adjustment.
        //                             This parameter can be a value of @ref RTC_DayLightSaving_Definitions */

        //    uint32_t StoreOperation;  /*!< Specifies RTC_StoreOperation value to be written in the BCK bit 
        //                             in CR register to store the operation.
        //                             This parameter can be a value of @ref RTC_StoreOperation_Definitions */
        //}
        //RTC_TimeTypeDef;  

        //typedef struct
        //{
        //    uint8_t WeekDay;  /*!< Specifies the RTC Date WeekDay.
        //                     This parameter can be a value of @ref RTC_WeekDay_Definitions */

        //    uint8_t Month;    /*!< Specifies the RTC Date Month (in BCD format).
        //                     This parameter can be a value of @ref RTC_Month_Date_Definitions */

        //    uint8_t Date;     /*!< Specifies the RTC Date.
        //                     This parameter must be a number between Min_Data = 1 and Max_Data = 31 */

        //    uint8_t Year;     /*!< Specifies the RTC Date Year.
        //                     This parameter must be a number between Min_Data = 0 and Max_Data = 99 */

        //}
        //RTC_DateTypeDef;


            
        #endregion



        #region fields

        byte Hours;
        byte Minutes;
        byte Seconds;
        
        byte WeekDay;
        byte Month;
        byte Day;
        byte Year;



        #endregion

        #region cstor

        public RtcDateTime()
        {

        }

        #endregion

        #region properties

        public byte HOURS
        {
            get { return Hours; }
        }
        
        public byte MINUTES
        {
            get { return Minutes; }
        }

        public byte SECONDS
        {
            get { return Seconds;  }
        }
        
        public byte WEEKDAY
        {
            get { return WeekDay; }
        }

        public byte MONTH
        {
            get { return Month; }
        }

        public byte DAY
        {
            get { return Day; }
        }

        public byte YEAR
        {
            get { return Year; }
        }


        #endregion


        #region functions

        void init_now()
        {
            DateTime dt_now = DateTime.Now;

            Hours = (byte)dt_now.Hour;
            Minutes = (byte)dt_now.Minute;
            Seconds = (byte)dt_now.Second;
            
            WeekDay = (byte)dt_now.DayOfWeek;
            Month = (byte)dt_now.Month;
            Day = (byte)dt_now.Day;
            Year = (byte)(dt_now.Year-2000);

        
        }

        public string GetStringDateTimeNow()
        {
            init_now();

            return String.Format("h{0}m{1}s{2}w{3}d{4}m{5}y{6}", Hours, Minutes, Seconds, WeekDay, Month, Day, Year);

        }

        public byte[] GetDateTimeBytesFromNow()
        {
            init_now();

            byte[] ary_date_time = new byte[11];

            ary_date_time[0] = (byte)'$';
            ary_date_time[1] = Hours;          // hours
            ary_date_time[2] = Minutes;           // minutes
            ary_date_time[3] = Seconds;           // seconds
            ary_date_time[4] = (byte)'w';   
            ary_date_time[5] = WeekDay;           // weekday
            ary_date_time[6] = (byte)'%';
            ary_date_time[7] = Day;           // Month
            ary_date_time[8] = Month;           // Day
            ary_date_time[9] = Year;           // Year
            ary_date_time[10] = (byte)'!';





            return ary_date_time;
        }

        public byte[] GetBCD_DateTimeBytesFromNow()
        {
            byte bcd_byte = 0;
            init_now();

            byte[] ary_date_time = new byte[11];

            ary_date_time[0] = (byte)'$';

            // Hours 1
            bcd_byte = (byte)(Hours / 10);
            bcd_byte <<= 4;
            bcd_byte|= (byte)(Hours % 10);

            ary_date_time[1] = bcd_byte;    // Hours

            // Minutes 2
            bcd_byte = (byte)(Minutes / 10);
            bcd_byte <<= 4;
            bcd_byte |= (byte)(Minutes % 10);

            ary_date_time[2] = bcd_byte;  // Minutes

            // Seconds 3
            bcd_byte = (byte)(Seconds / 10);
            bcd_byte <<= 4;
            bcd_byte |= (byte)(Seconds % 10);

            ary_date_time[3] = bcd_byte;  // Seconds
            
            ary_date_time[4] = (byte)'w';

            ary_date_time[5] = WeekDay;             // WDU_3_bits
            
            ary_date_time[6] = (byte)'%';

            // Day 7
            bcd_byte = (byte)(Day / 10);
            bcd_byte <<= 4;
            bcd_byte |= (byte)(Day % 10);

            ary_date_time[7] = bcd_byte;     // Day

            //Month 8
            bcd_byte = (byte)(Month / 10);
            bcd_byte <<= 4;
            bcd_byte |= (byte)(Month % 10);

            ary_date_time[8] = bcd_byte; //Month

            // Year 9
            bcd_byte = (byte)((Year-2000) / 10);
            bcd_byte <<= 4;
            bcd_byte |= (byte)((Year-2000) % 10);

            ary_date_time[9] = bcd_byte; // Year

            ary_date_time[10] = (byte)'!';
            
            return ary_date_time;
        }


        #endregion

    }
}
