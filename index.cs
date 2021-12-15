    using System;
    using System.Linq;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public delegate object[] BeforeDelegate(object[] datas);
            
             public int Compute(object[] dataSet) 
             {
                 BeforeDelegate todoBefore = CleanDataSet;
                 var result = SumData(todoBefore, dataSet);
                 return result;
            }
            
            public object[] CleanDataSet(object[] datas)
            {
                var cleanSet = new List<object>();
                
                foreach(var d in datas)
                {
                    if(d.GetType() == typeof(int))
                    {
                        cleanSet.Add(d);
                    }
                }
            return cleanSet.ToArray();
            }
            
            public int SumData(BeforeDelegate cleanData,object[] datas)
            {
                var result = 0;
                if(cleanData != null)
                {
                    datas = cleanData(datas);
                }
                try {
                    foreach(var o in datas){
                        result +=((int)o);
                    };
                }
                catch(Exception){
                Console.WriteLine("Les données sont corrompues");
                return 0;
            }
            return result;
            }
        }
    }