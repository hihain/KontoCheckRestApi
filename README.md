# KontoCheckRestApi
A minimal REST API (example) for the _konto_check_ library by Michael Plugge based on ASP.NET Core 3.1.
The REST API can be tested using swagger.
Currently, there are two routes: one requires an IBAN and another Kto/BLZ to return the following information:
```yaml
{
  "kontonummer": "string",
  "bankleitzahl": "string",
  "iban": "string",
  "bic": "string",
  "hinweis": "string"
}
```

## Debugging
Use Visual Studio 2019 to debug. Release setting work out of the box, for debugging you need to compile and install the _konto_check_ library manually in the docker container. It might be necessary to comment out the library initialization in the `Startup.cs`.

## Release
Just [build](https://docs.docker.com/engine/reference/commandline/build/) and [run](https://docs.docker.com/engine/reference/commandline/run/) using docker.

## Updating
The `blz.lut` file should be updated from time to time. All _konto_check_ related files can be found in the folder with that name.

## References
* [konto_check project website](https://www.michael-plugge.de/konto_check/index.php)
