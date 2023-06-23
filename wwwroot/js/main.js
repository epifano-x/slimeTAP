function mudarTela(numeroTela) {
    var telas = document.getElementsByClassName('tela');
    for (var i = 0; i < telas.length; i++) {
      telas[i].style.display = 'none';
      
      var upgrades = telas[i].getElementsByClassName('upgrade');
      for (var j = 0; j < upgrades.length; j++) {
        upgrades[j].style.display = 'none';
      }
    }
    
    var telaSelecionada = document.getElementsByClassName('tela')[numeroTela - 1];
    telaSelecionada.style.display = 'block';
    
    var upgradesSelecionados = telaSelecionada.getElementsByClassName('upgrade');
    for (var k = 0; k < upgradesSelecionados.length; k++) {
      upgradesSelecionados[k].style.display = 'flex';
    }
    
    // Remove a classe "selected" de todos os ícones
    var icones = document.getElementsByClassName('icone2');
    for (var l = 0; l < icones.length; l++) {
      icones[l].classList.remove('selected');
    }
    
    // Adiciona a classe "selected" ao botão selecionado
    var botaoSelecionado = document.getElementsByClassName('icone2')[numeroTela - 1];
    botaoSelecionado.classList.add('selected');
  }
  
  function toggleMenu() {
    var menu = document.querySelector('.container2 .menu');
    menu.classList.toggle('menu-displayed');
  }

  
  function zoomImage() {
    var image = document.querySelector('.image-container img');
    image.classList.add('zoom-animation');
    setTimeout(function() {
      image.classList.remove('zoom-animation');
    }, 200);
  }
  
  document.querySelector('.div2').onclick = function() {
    zoomImage();
  };


  function bloquearSelecaoTexto() {
    // Impede a ação padrão de seleção de texto no evento 'mousedown'
    document.addEventListener('mousedown', function(event) {
      event.preventDefault();
    });
  }
  
  bloquearSelecaoTexto()
  
  