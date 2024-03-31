# CountryFlags - Release Procedure

## Before Starting

- Checkout the master branch.
- Verify the consistency of the version throughout the entire project:
  - Verify the content of the `doc\readme.txt` file.
  - Verify the content of the `doc\changelog.txt` file.
  - Verify the version to be consistent in all files:
    - `doc\readme.txt` file;
    - `doc\changelog.txt` file;
    - `sources\Directory.build.props` file;
    - `release\CountryFlags.proj` file.


## Step 1 - Create the release

- Open a Developer Command Prompt for Visual Studio
- Run the `CountryFlags.proj` file:

```
msbuild CountryFlags.proj
```

The resulted files are located in the `output` directory.

## Step 2 - Increment version

Increment the version in all files:

- `doc\readme.txt` file;
- `doc\changelog.txt` file;
- `sources\Directory.build.props` file;
- `release\CountryFlags.proj` file.
