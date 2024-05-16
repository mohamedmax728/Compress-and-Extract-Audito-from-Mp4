// See https://aka.ms/new-console-template for more information
using NReco.VideoConverter;
Console.WriteLine("Hello, World!");
string inputFilePath = "D:\\New folder (13)\\lv_0_20240516150810.mp4";
string outputFilePath = "D:\\New folder (13)\\lv_0_22.H264";
string audioFilePath = "D:\\New folder (13)\\lv_0_222.mp3";

try
{
    //await Task.WhenAll(
    //    ExtractAudioAsync(inputFilePath, audioFilePath)
    //   , CompressVideoAsync(inputFilePath, outputFilePath)
    //    );
    ExtractAudioAsync(inputFilePath, audioFilePath);
    CompressVideoAsync(inputFilePath, outputFilePath);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

static async Task CompressVideoAsync(string inputFile, string outputFile)
{
    //FileStream fs = File.Create(outputFile);
    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
    ffMpeg.ConvertMedia(inputFile, outputFile, Format.h264);
}
static async Task ExtractAudioAsync(string inputFile, string audioFilePath)
{
    //FileStream fs = File.Create(outputFile);
    var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
    ffMpeg.ConvertMedia(inputFile, audioFilePath, "mp3");
}
