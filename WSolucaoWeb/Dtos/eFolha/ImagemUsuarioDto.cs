﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Persistencia.Validations.CustomValidations;

namespace WSolucaoWeb.Dtos.eFolha
{
    public class ImagemUsuarioDto
    {
        [DataType(DataType.Upload)]
        [MaxFileSize(5 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile imagem { get; set; }
    }
}
