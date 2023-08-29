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

    [HttpPost("GetKassenzettelData")]
    [Consumes("multipart/form-data")]
    public string AnalysePhoto(IFormFile file)
    {
        MemoryStream memoryStream = new MemoryStream();
        file.CopyTo(memoryStream);
        byte[] fileBytes = memoryStream.ToArray();

        Pix pix = Pix.LoadFromMemory(fileBytes);
        Page page = _engine.Process(pix);

        string text = page.GetText();
        return text;
    }
};