using Microsoft.AspNetCore.Mvc;
using Tesseract;

namespace KassenzettelApi.OcrController;

[ApiController]
[Route("ocr")]
public class OcrController : ControllerBase
{
    private readonly ILogger _logger;

    public OcrController(ILogger logger)
    {
        _logger = logger;
    }

    [HttpGet("GetKassenzettelData")]
    public void AnalysePhoto()
    {

    }
};