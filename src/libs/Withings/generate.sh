dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
# Manual spec — no public OpenAPI spec available from Withings
autosdk generate openapi.yaml \
  --namespace Withings \
  --clientClassName WithingsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
