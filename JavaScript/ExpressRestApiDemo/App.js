const express = require('express')
const app = express()
const port = 3000

app.get('/', (req, res) => {
  
    const olio = {
        nimi: "Matti Möttönen",
        puhelin: "050 111 2222"
    }

    res.json(olio);
})

app.listen(port, () => {
  console.log(`Example app listening at http://localhost:${port}`)
})
