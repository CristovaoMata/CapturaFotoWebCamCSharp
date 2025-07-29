# 📸 CapturaFotoWebCamCshap

 Sistema simples desenvolvido em \*\*C# Windows Forms (.NET Framework 4.7.2)\*\* para capturar fotos a partir de uma câmera (webcam) conectada ao computador, com funcionalidade para visualizar a imagem ao vivo, capturar, exibir a foto capturada e salvar no disco.

# ✅ Útil para aplicações como: emissão de cartões de estudante, crachás, cadastro com foto, controle de acesso e muito mais.

---

# 🧰 Funcionalidades

- 📷 Captura de vídeo ao vivo da webcam.

- 🖼️ Visualização em tempo real na interface (`PictureBox`).

- 📌 Captura de imagem da câmera com um clique.

- 💾 Salvamento da imagem capturada em disco (formato JPEG).

- 🗂️ Criação automática da pasta `fotos` para armazenamento.

---

# 📁 Estrutura do Projeto

- `FrmCapturaFoto.cs` – Formulário principal com toda a lógica e interface gráfica.

- Nenhuma classe adicional. Projeto enxuto e direto ao ponto.

 Pasta `fotos/` (criada automaticamente ao salvar fotos).

---

#  🔧 Requisitos

- Sistema operacional: Windows 7, 8, 10 ou 11

- .NET Framework 4.7.2

- Webcam instalada e funcionando

# ---


# 📦 Dependências


O projeto utiliza a biblioteca \*\*\[AForge.NET](http://www.aforgenet.com/framework/)\*\* para acesso à câmera:

Você pode instalar via \*\*NuGet\*\* no Visual Studio:

  ``powershell ``

Install-Package AForge

Install-Package AForge.Video

Install-Package AForge.Video.DirectShow



