#include "sudolib.cpp"

extern "C" __declspec(dllexport) GRID * CPP_Creategrid()
{
    return new GRID();
}

extern "C" __declspec(dllexport) void CPP_Deletegrid(GRID * _grid)
{
    delete _grid;
}

extern "C" __declspec(dllexport) void* CPP_Fillgrid(GRID* _grid)
{
    _grid->Fillgrid();
    return (void*)_grid->vector;
}

extern "C" __declspec(dllexport) void* CPP_Removedigits(GRID * _grid, int retries)
{
    _grid->Removedigits(retries);
    return (void*)_grid->vector;
}

extern "C" __declspec(dllexport) bool CPP_Solveunique(GRID * _grid)
{
    return _grid->Solveunique();
}

extern "C" __declspec(dllexport) void* CPP_Solveit(GRID * _grid)
{
    _grid->Solveit();
    return (void*)_grid->vector;
}

extern "C" __declspec(dllexport) void* CPP_Emptygrid(GRID * _grid)
{
    _grid->Emptygrid();
    return (void*)_grid->vector;
}

extern "C" __declspec(dllexport) unsigned long CPP_Createrandomsequence(
    GRID * _grid, long long seed)
{
    unsigned long puzzleid;
    puzzleid = _grid->Createrandomsequence(seed);
    return puzzleid;
}
