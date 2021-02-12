const express = require('express')
const app = express()
const port = 3000

app.get('/', (req, res) => {
  
    const olio = {
        nimi: "Matti Möttönen",
        puhelin: "050 111 2222"
    };

    res.json(olio);
});

app.get('/toka', (req, res) => {
  
    const olio = {
        nimi: "Teppo Testaaja",
        puhelin: "050 9876 543"
    };

    res.json(olio);
});

app.post('/', (req, res) => {
  
    const status = {
        success: true,
        error: null
    };

    res.json(status);
});


app.listen(port, () => {
  console.log(`Example app listening at http://localhost:${port}`)
});
