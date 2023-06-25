using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using slimeTAP.Models;
using SlimeTAP.RazorPages.Data;

namespace SlimeTAP.Pages.Main
{
    public class main : PageModel
    {
        private readonly ILogger<main> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly RazorPages.Data.AppDbContext _dbContext;
        public main(ILogger<main> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            Usuario = new UsuarioModel();
        }

        public UsuarioModel Usuario { get; set; }
        public List<SlimeData>? Slimes { get; set; }
        public int UpgradeValue { get; set; }
        public int Level { get; set; }
        public int Moeda { get; set; }
        public int Diamante { get; set; }
        public int Gema { get; set; }

        public string UsuarioNome { get; set; } // Propriedade para armazenar o nome do usuário

        public UsuarioModel? existingUser { get; set; }

        public void OnGet()
        {
            

            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            // Resto do código...
            if (!string.IsNullOrEmpty(usuarioNomeCookie))
        {
            UsuarioNome = usuarioNomeCookie;
            existingUser = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            UpgradeValue = Convert.ToInt32(existingUser.Upgrade1);
            Level = Convert.ToInt32(existingUser.Level);
            Moeda = Convert.ToInt32(existingUser.Moeda);
            Diamante = Convert.ToInt32(existingUser.Diamante);
            Gema = Convert.ToInt32(existingUser.Gema);
            Slimes = GenerateSlimeData(UpgradeValue);
        }
        }


        public IActionResult OnPostIncrementSlime()
        {
            var httpContext = HttpContext;
            // Agora você pode acessar a propriedade HttpContext para obter o acesso à sessão, por exemplo:
            string usuarioNomeCookie = Request.Cookies["UsuarioNome"];
            Usuario = _dbContext.Set<UsuarioModel>().FirstOrDefault(u => u.UsuarioNome == usuarioNomeCookie);
            if (Usuario != null)
            {
                if(Usuario.Level > 10){
                    Usuario.Level -= 10;
                    Usuario.Upgrade1 += 1;
                    _dbContext.SaveChanges(); // Salva as alterações no banco de dados

                    // Redirecionar para a página principal sem adicionar o handler à URL
                    return RedirectToPage("/Main/main");
                }else{
                    return RedirectToPage("/Main/main");
                    
                }

            }

            // Restante da lógica...

            // Em caso de erro ou algum outro resultado, você pode retornar uma resposta adequada
            return BadRequest();
        }



        public class SlimeData
        {
            public int X { get; set; }
            public int Y { get; set; }
            public string? ImageFileName { get; set; }
            public int ZIndex { get; set; }
        }

        private List<SlimeData> GenerateSlimeData(int upgradeValue)
        {
            List<SlimeData> data = new List<SlimeData>();

            List<string> slimeImageFiles = new List<string>
            {
                "slime1.png",
                "slime2.png",
                "slime3.png",
                "slime4.png",
                "slime5.png",
                "slime6.png",
                "slime7.png",
                "slime8.png",
                "slime9.png",
                // Adicione mais nomes de arquivos de imagem para cada tipo de slime
            };

            int containerWidth = 50; // Largura do contêiner em porcentagem
            int containerHeight = 100; // Altura do contêiner em porcentagem

            int slimeWidth = 30; // Largura do slime em porcentagem
            int slimeHeight = 100; // Altura do slime em porcentagem

            int spacing = (containerWidth - upgradeValue * slimeWidth) / (upgradeValue + 1); // Espaçamento entre os slimes em porcentagem

            int totalWidth = upgradeValue * slimeWidth + (upgradeValue + 1) * spacing;
            int offsetX = (containerWidth - totalWidth) / 2; // Deslocamento em porcentagem para o centro dos slimes

            for (int i = 0; i < upgradeValue; i++)
            {
                int x = offsetX + (i + 1) * spacing + i * slimeWidth;
                int y = (containerHeight - slimeHeight) / 2; // Posição Y centralizada

                SlimeData slime = new SlimeData
                {
                    X = x,
                    Y = y,
                    ImageFileName = slimeImageFiles[i % slimeImageFiles.Count], // Obtenha o nome de arquivo de imagem com base no índice
                };

                data.Add(slime);
            }

            return data;
        }
    }
}