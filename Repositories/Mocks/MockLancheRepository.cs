using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LanchesMac.Repositories.Mocks
{
    public class MockLancheRepository : ILancheRepository
    {
        private readonly ICategoriaRepository _categoriaRepository = new MockCategoriaRepository();

        public IEnumerable<Lanche> Lanches
        {
            get
            {
                return new List<Lanche>
                {
                    new Lanche {
                        Nome = "Cheese Salada",
                        Preco = 12.50M,
                        DescricaoCurta = "Pão, hambúrger, ovo, presunto, queijo e batata palha",
                        DescricaoDetalhada = "Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "https://s2.glbimg.com/X_fa12dG6bRDkVnNMR2RhHdOpp4=/0x0:248x203/1280x0/smart/filters:strip_icc()/s.glbimg.com/po/rc/media/2012/12/19/21_32_24_757_download_1_.jpg",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "https://i2.wp.com/radames.manosso.nom.br/linguagem/files/x-salada.jpg?zoom=2&resize=440%2C320",
                    },
                    new Lanche {
                        Nome = "Misto Quente",
                        Preco = 8.00M,
                        DescricaoCurta = "Pão, presunto, mussarela e tomate",
                        DescricaoDetalhada = "Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "https://scm-assets.constant.co/scm/unilever/1d398653b55393fd6da9bff8ea193338/fc0cc6a6-f09a-4c11-a30c-1518588d9888.jpg",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "https://t2.uc.ltmcdn.com/pt/images/4/6/0/img_como_fazer_um_misto_quente_24064_600.jpg",
                    },
                    new Lanche {
                        Nome = "Cheese Burger",
                        Preco = 11.00M,
                        DescricaoCurta = "Pão, hambúrger, presunto, mussarela e batalha palha ",
                        DescricaoDetalhada = "Pão de hambúrger especial com hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "https://www.foodrepublic.com/wp-content/uploads/2012/03/033_FR11785.jpg",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "https://d1doqjmisr497k.cloudfront.net/-/media/mccormick-us/recipes/frenchs/t/800/triple_mustard_bacon_cheese_burger800x800.jpg",
                    },
                    new Lanche
                    {
                        Nome = "X-Tudo",
                        Preco = 15.00M,
                        DescricaoCurta = "Pão, Hambúrger, ovo, bacon, presunto, mussarela, alface, tomate e batata palha",
                        DescricaoDetalhada = "Pão fresquinho com hambúrger especial e ovo frito com bacon, presunto e mussarela; tomate e alface fresquinhos. Acompanha batata palha",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "https://img.itdg.com.br/tdg/images/recipes/000/137/370/288363/288363_original.jpg?w=1200",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "https://img.itdg.com.br/tdg/images/recipes/000/076/733/239570/239570_original.jpg?mode=crop&width=710&height=400",
                    },
                     new Lanche
                    {
                        Nome = "Lanche Natural",
                        Preco = 10.00M,
                        DescricaoCurta = "Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte",
                        DescricaoDetalhada = "Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "https://receitanatureba.com/wp-content/uploads/2018/05/capa-43.jpg",
                        EmEstoque = true,
                        IsLanchePreferido = true,
                        ImagemThumbnailUrl = "https://www.confeiteiradesucesso.com/wp-content/uploads/2017/12/sanduichenaturalreceitas.jpg",
                    }
                };
            }
        }

        public IEnumerable<Lanche> LanchesPreferidos { get; }
        public Lanche GetLancheById(int lancheId)
        {
            throw new NotImplementedException();
        }
    }
}
