using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScikitLearn;

public readonly struct AllowedTypes<T0, T1>
    where T0 : notnull
    where T1 : notnull
{
    private readonly bool _is_instance = default;
    private readonly T0? _value0 = default;
    private readonly T1? _value1 = default;
    private readonly int _index = default;

    public bool IsDefault => !_is_instance;

    private AllowedTypes(int index, T0? value0 = default, T1? value1 = default)
    {
        _is_instance = true;
        _index = index;
        _value0 = value0;
        _value1 = value1;
    }

    public static implicit operator AllowedTypes<T0, T1>(T0 t) => new(0, value0: t);
    public static implicit operator AllowedTypes<T0, T1>(T1 t) => new(1, value1: t);

    public bool IsT0 => _is_instance && _index == 0;
    public bool IsT1 => _is_instance && _index == 1;

    public T0 AsT0 => _index != 0 ? throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}") : _value0!;
    public T1 AsT1 => _index != 1 ? throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}") : _value1!;
}

public readonly struct AllowedTypesOrNull<T0, T1, T2>
    where T1 : notnull
    where T2 : notnull
{
    private readonly bool _is_instance = default;
    private readonly T0? _value0 = default;
    private readonly T1? _value1 = default;
    private readonly T2? _value2 = default;
    private readonly int _index = default;

    public bool IsDefault => !_is_instance;

    private AllowedTypesOrNull(int index, T0? value0 = default, T1? value1 = default, T2? value2 = default)
    {
        _is_instance = true;
        _index = index;
        _value0 = value0;
        _value1 = value1;
        _value2 = value2;
    }

    public static implicit operator AllowedTypesOrNull<T0, T1, T2>(T0? t) => new(0, value0: t);
    public static implicit operator AllowedTypesOrNull<T0, T1, T2>(T1 t) => new(1, value1: t);
    public static implicit operator AllowedTypesOrNull<T0, T1, T2>(T2 t) => new(2, value2: t);

    public bool IsT0 => _is_instance && _index == 0;
    public bool IsT1 => _is_instance && _index == 1;
    public bool IsT2 => _is_instance && _index == 2;

    public T0 AsT0 => _index != 0 ? throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}") : _value0!;
    public T1 AsT1 => _index != 1 ? throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}") : _value1!;
    public T2 AsT2 => _index != 2 ? throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}") : _value2!;
}

public readonly struct AllowedTypes<T0, T1, T2>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
{
    private readonly bool _is_instance = default;
    private readonly T0? _value0 = default;
    private readonly T1? _value1 = default;
    private readonly T2? _value2 = default;
    private readonly int _index = default;

    public bool IsDefault => !_is_instance;

    private AllowedTypes(int index, T0? value0 = default, T1? value1 = default, T2? value2 = default)
    {
        _is_instance = true;
        _index = index;
        _value0 = value0;
        _value1 = value1;
        _value2 = value2;
    }

    public static implicit operator AllowedTypes<T0, T1, T2>(T0 t) => new(0, value0: t);
    public static implicit operator AllowedTypes<T0, T1, T2>(T1 t) => new(1, value1: t);
    public static implicit operator AllowedTypes<T0, T1, T2>(T2 t) => new(2, value2: t);

    public bool IsT0 => _is_instance && _index == 0;
    public bool IsT1 => _is_instance && _index == 1;
    public bool IsT2 => _is_instance && _index == 2;

    public T0 AsT0 => _index != 0 ? throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}") : _value0!;
    public T1 AsT1 => _index != 1 ? throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}") : _value1!;
    public T2 AsT2 => _index != 2 ? throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}") : _value2!;
}