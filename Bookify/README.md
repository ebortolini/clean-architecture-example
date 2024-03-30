# Running instructions

## Using docker-compose-services-only

This docker file just runs the external services while letting the Api run directly from Visual Studio without docker.

```
docker-compose  -f .\docker-compose-services-only.yml up/down
```