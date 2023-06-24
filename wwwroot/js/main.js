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

  
  function zoomImage(element) {
    element.classList.add('zoom-animation');

    setTimeout(function() {
        element.classList.remove('zoom-animation');
    }, 200);
}


document.querySelector('.div2').onclick = function() {
  var slimeImages = document.querySelectorAll('.slime img');
  
  slimeImages.forEach(function(image) {
    zoomImage(image);
  });
};



  function bloquearSelecaoTexto() {
    // Impede a ação padrão de seleção de texto no evento 'mousedown'
    document.addEventListener('mousedown', function(event) {
      event.preventDefault();
    });
  }
  
  bloquearSelecaoTexto()
  

  var div2 = document.querySelector('.div2');

  div2.addEventListener('click', function(event) {
    var x = event.clientX;
    var y = event.clientY;

    var moeda = document.createElement('div');
    moeda.classList.add('moeda');
    moeda.style.left = x + 'px';
    moeda.style.top = y + 'px';

    div2.appendChild(moeda);

    setTimeout(function() {
      div2.removeChild(moeda);
    }, 1000);
  });

  $(document).ready(function () {
    // Manipulador de evento para o clique no botão
    $("#myButton").click(function () {
        // Chamada AJAX para o manipulador de eventos no servidor
        $.ajax({
            type: "POST",
            url: "/Main",
            data: { handler: "IncrementUpgradeValue" },
            success: function (response) {
                // Atualiza o valor exibido na página
                $("#upgradeValue").text(response.upgradeValue);
            },
            error: function () {
                alert("Erro ao incrementar o valor!");
            }
        });
    });
});