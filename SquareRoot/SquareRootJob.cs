
using Microsoft.Hadoop.MapReduce;
// using Microsoft.Hadoop.WebClient.WebHCatClient;

// https://www.youtube.com/watch?v=uyi41nrhlhw
namespace SquareRoot
{


    public class SqrtMapper : MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            int inputValue = int.Parse(inputLine);

            // Perform the work
            double sqrt = System.Math.Sqrt((double)inputValue);


            context.EmitKeyValue(inputValue.ToString(), sqrt.ToString());
        } // End Sub Map 
    } // End Class SqrtMapper


    public class SqrtJob : HadoopJob<SqrtMapper>
    {
        public override HadoopJobConfiguration Configure(ExecutorContext context)
        {
            HadoopJobConfiguration config = new HadoopJobConfiguration();
            config.InputPath = "Input/sqrt";
            config.OutputFolder = "Output/sqrt";

            return config;
        } // End Function Configure
    } // End Class SqrtJob


    class HelperClass
    {

        // The environment is not suitable:
        // Environment variable not set: Java_HOME
        // Environment variable not set: HADOOP_HOME
        public static void Test()
        {
            IHadoop ha = Hadoop.Connect();
            Microsoft.Hadoop.WebClient.WebHCatClient.MapReduceResult result = ha.MapReduceJob.ExecuteJob<SqrtJob>();
        } // End Sub Main 

    } // End Class HelperClass


}
