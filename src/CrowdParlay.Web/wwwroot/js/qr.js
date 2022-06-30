window.addEventListener("load", () => {
    const uri = document.getElementById("qrCodeData").getAttribute('data-url');
    const qrCode = new QRCodeStyling({
        width: 300,
        height: 300,
        type: "svg",
        data: uri,
        dotsOptions: {
            type: "extra-rounded"
        },
        cornersSquareOptions: {
            type: "extra-rounded"
        },
        imageOptions: {
            crossOrigin: "anonymous",
            margin: 0
        }
    });
    qrCode.append(document.getElementById("qrCode"));
});