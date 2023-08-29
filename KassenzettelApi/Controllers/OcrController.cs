using Microsoft.AspNetCore.Mvc;
using Tesseract;

namespace KassenzettelApi.OcrController;

[ApiController]
[Route("ocr")]
public class OcrController : ControllerBase
{
    private TesseractEngine _engine = new(
        @"C:\Users\palzer\Desktop\Kassenzettelapp\BE\KassenzettelApi\KassenzettelApi\OcrFiles",
        "deu",
        EngineMode.Default);

    [HttpGet("GetKassenzettelData")]
    public void AnalysePhoto()
    {
        string imagePath = @"C:\Users\palzer\Desktop\Kassenzettelapp\BE\KassenzettelApi\KassenzettelApi\OcrFiles\BeispielKassenzettel.png";
        Pix image = Pix.LoadFromFile(imagePath);
        Page page = _engine.Process(image);

        Console.WriteLine();
    }
};