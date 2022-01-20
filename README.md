# DocSlides

После сборки проекта вызвать в терминале:

```console
$ cd .\target\generated-slides\
$ ruby -run -e httpd . -p 5000 -b 127.0.0.1
```
Затем в браузере пройти по ссылке http://localhost:5000.

Заметки докладчика открываются нажатием S

## Печать в файл
https://github.com/hakimel/reveal.js/blob/v3.9/README.md#pdf-export

Open your presentation with print-pdf included in the query string i.e. http://localhost:5000/?print-pdf. You can test this with revealjs.com?print-pdf.

If you want to include speaker notes in your export, you can append showNotes=true to the query string: http://localhost:5000/?print-pdf&showNotes=true