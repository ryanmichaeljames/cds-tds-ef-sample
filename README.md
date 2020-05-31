# Common Data Service and Entity Framework Sample

This project is a simple sample of how to consume the Common Data Service's Tabular Data Stream (TDS) endpoint using Entity Framework.

## Getting Started

The following instructions will get a copy of the project up and running on your local machine.

### Prerequisites

The TDS endpoint must be enabled on your CDS environment.
> For a guide on how to enable TDS please see [https://ryanjames.dev/blog/2020/05/29/use-sql-to-query-cds/#enabling-the-tds-endpoint](https://ryanjames.dev/blog/2020/05/29/use-sql-to-query-cds/#enabling-the-tds-endpoint)

### Setup

Update the `appsettings.json` file with the TDS endpoint connection string. 

```
{
    "ConnectionStrings": {
        "cds": "Server=<ORGNAME>.crm.dynamics.com,5558;Authentication=Active Directory Password;Database=<ORGNAME>;UID=<USERNAME>;PWD=<PASSWORD>"
    }
}
```

Alternatively you can set the connection string in the user secrets by updating the `secrets.json` file. On windows the user secrets are found in `%APPDATA%\Microsoft\UserSecrets\<USER_SECRETS_ID>\secrets.json` while on macOS and Linux they are found in `~/.microsoft/usersecrets/<USER_SECRETS_ID>/secrets.json`.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details