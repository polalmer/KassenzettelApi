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

    [HttpPost("Kassenzettel")]
    [Consumes("multipart/form-data")]
    public string AnalysePhoto(IFormFile file)
    {
        MemoryStream memoryStream = new();
        file.CopyTo(memoryStream);
        byte[] fileBytes = memoryStream.ToArray();

        Pix pix = Pix.LoadFromMemory(fileBytes);
        Page page = _engine.Process(pix);

        ExtractData(page);

        return page.GetText();
    }

    private void ExtractData(Page page)
    {
        string text = page.GetText();
    }
};